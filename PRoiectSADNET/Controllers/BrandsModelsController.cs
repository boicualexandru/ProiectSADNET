using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.BrandModels;
using Services.BrandModels.Models;

namespace PRoiectSADNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsModelsController : ControllerBase
    {
        private readonly IBrandModelsService _brandModelsService;

        public BrandsModelsController(IBrandModelsService brandModelsService)
        {
            _brandModelsService = brandModelsService;
        }

        // GET BrandsModels/Brands
        [HttpGet("Brands")]
        public ActionResult<IList<BrandModel>> GetBrands()
        {
            return Ok(_brandModelsService.GetBrands());
        }

        // GET BrandsModels/Models
        [HttpGet("Models")]
        public ActionResult<IList<ModelModel>> GetModelsByBrandId([FromQuery] int brandId)
        {
            return Ok(_brandModelsService.GetModelsByBrandId(brandId));
        }
    }
}