using Data.Models;
using Services.BrandModels.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.BrandModels
{
    public class BrandModelsService : IBrandModelsService
    {
        private readonly AppDBContext _dbContext;

        public BrandModelsService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<BrandModel> GetBrands()
        {
            return _dbContext.Brands
                .Select(brand => new BrandModel { Id = brand.Id, Name = brand.Name });
        }

        public IEnumerable<ModelModel> GetModelsByBrandId(int brandId)
        {
            return _dbContext.Models
                .Where(model => model.BrandId == brandId)
                .Select(model => new ModelModel { Id = model.Id, Name = model.Name });
        }
    }
}
