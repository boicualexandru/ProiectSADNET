using System.Collections.Generic;
using System.Linq;
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
                .Where(r => r.ManufactureDate >= filters.DateRange.Start &&
                    r.ManufactureDate <= filters.DateRange.End);
            
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

            return filteredRecords.Select(r => new YearPriceModel {
                Year = r.ManufactureDate.Year,
                Price = r.Price
            });
        }
    }
}
