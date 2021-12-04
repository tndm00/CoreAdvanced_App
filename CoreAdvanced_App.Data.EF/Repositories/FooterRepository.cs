using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class FooterRepository : EFRepository<Footer, string>, IFooterRepository
    {
        public FooterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}