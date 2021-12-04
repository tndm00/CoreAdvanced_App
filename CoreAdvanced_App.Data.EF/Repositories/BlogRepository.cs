using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class BlogRepository : EFRepository<Blog, int>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}