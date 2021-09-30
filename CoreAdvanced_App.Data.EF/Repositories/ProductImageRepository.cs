using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class ProductImageRepository : EFRepository<ProductImage, int>, IProductImageRepository
    {
        public ProductImageRepository(AppDbContext context) : base(context)
        {
        }
    }
}