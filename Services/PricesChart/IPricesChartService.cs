using Services.PricesChart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PricesChart
{
    public interface IPricesChartService
    {
        IEnumerable<YearPriceModel> GetPricesByManufactureDate(PricesChartFilterOptions filters);
    }
}
