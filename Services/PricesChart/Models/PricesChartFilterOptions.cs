using Common;
using Data.Models;

namespace Services.PricesChart.Models
{
    public class PricesChartFilterOptions
    {
        public IntRange YearRange { get; set; }

        public int? BrandId { get; set; }

        public int? ModelId { get; set; }

        public FuelType? FuelType { get; set; }
    }
}
