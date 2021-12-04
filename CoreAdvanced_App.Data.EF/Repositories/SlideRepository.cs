using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class SlideRepository : EFRepository<Slide, int>, ISlideRepository
    {
        public SlideRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}