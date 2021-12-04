using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class SystemConfigRepository : EFRepository<SystemConfig, string>, ISystemConfigRepository
    {
        public SystemConfigRepository(AppDbContext dbFactory) : base(dbFactory)
        {
        }
    }
}