using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Services.PricesChart.Models;

namespace Services.PricesChart
{
    public class PricesChartService : IPricesChartService
    {
        private readonly AppDBContext _dbContext;

        public PricesChartService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<YearPriceModel> GetPricesByManufactureDate(PricesChartFilterOptions filters)
        {
            var filteredRecords = _dbContext.Records
                .Where(r => r.ManufactureDate.Year >= filters.YearRange.Start &&
                    r.ManufactureDate.Year <= filters.YearRange.End);
            
            if(filters.ModelId != null)
            {
                filteredRecords = filteredRecords.Where(r => r.ModelId == filters.ModelId);
            }
            else if(filters.BrandId != null)
            {
                filteredRecords = filteredRecords.Include(r => r.Model)
                    .Where(r => r.Model.BrandId == filters.ModelId);
            }

            if(filters.FuelType != null)
            {
                filteredRecords = filteredRecords.Where(r => r.Fuel == filters.FuelType);
            }

            var groupedRecords = filteredRecords.GroupBy(r => r.ManufactureDate.Year)
                   .Select(g => new YearPriceModel
                   {
                       Year = g.Key,
                       Price = Convert.ToInt32(g.Average(r => r.Price))
                   });

            var result = FillGapsWithNull(groupedRecords.ToList(), filters.YearRange);

            return result;
        }

        private IList<YearPriceModel> FillGapsWithNull(IList<YearPriceModel> dataSet, IntRange yearRange)
        {
            var yearCount = yearRange.End - yearRange.Start + 1;
            return Enumerable.Range(yearRange.Start, yearCount)
                .Select(year =>
                    dataSet.FirstOrDefault(yearPrice => yearPrice.Year == year) ??
                        new YearPriceModel { Year = year, Price = null })
                .ToList();
        }
    }
}
