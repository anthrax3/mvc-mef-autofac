using Approach1.Core.Data.Repository;
using Approach1.Core.Model;
using Approach1.Core.Service;
using System.Collections.Generic;
using System.Linq;

namespace Approach1.Infrastructure.Service
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository brandRepository;
        public BrandService(IBrandRepository brandRepo)
        {
            this.brandRepository = brandRepo;
        }

        public List<BrandViewModel> GetAllBrands()
        {
            var allBrandCodes = this.brandRepository.GetAll().
                Select(b => new BrandViewModel { BrandCode = b.Code }).ToList();
            return allBrandCodes;
        }
    }
}
