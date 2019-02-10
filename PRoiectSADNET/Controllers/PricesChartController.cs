using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Services.PricesChart;
using Services.PricesChart.Models;

namespace PRoiectSADNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricesChartController : Controller
    {
        private readonly IPricesChartService _pricesChartService;

        public PricesChartController(IPricesChartService pricesChartService)
        {
            _pricesChartService = pricesChartService;
        }

        // POST PricesChart/ByManufactureDate
        [HttpPost("ByManufactureDate")]
        public ActionResult<IList<YearPriceModel>> ByManufactureDate([FromBody] PricesChartFilterOptions filters)
        {
            return Ok(_pricesChartService.GetPricesByManufactureDate(filters));
        }
    }
}