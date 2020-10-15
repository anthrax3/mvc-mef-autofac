using Approach1.Core.Data.Repository;
using Approach1.Infrastructure.Data;

namespace Approach1.Infrastructure.Repository
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(PrometheusBaseEntities context) : base(context)
        {
        }
    }
}
