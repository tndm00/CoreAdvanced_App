using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}