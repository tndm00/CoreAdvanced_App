using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class BlogTagRepository : EFRepository<BlogTag, int>, IBlogTagRepository
    {
        public BlogTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}