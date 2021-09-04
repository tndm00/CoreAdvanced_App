using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;
using System.Collections.Generic;
using System.Linq;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        private AppDbContext _context;

        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductCategory> GetByAlias(string alias)
        {
            return _context.ProductCategories.Where(_ => _.SeoAlias == alias).ToList();
        }
    }
}