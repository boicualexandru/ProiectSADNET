using Services.BrandModels.Models;
using System.Collections.Generic;

namespace Services.BrandModels
{
    public interface IBrandModelsService
    {
        IEnumerable<BrandModel> GetBrands();

        IEnumerable<ModelModel> GetModelsByBrandId(int brandId);
    }
}
