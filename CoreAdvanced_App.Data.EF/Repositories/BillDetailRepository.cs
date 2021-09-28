using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class BillDetailRepository : EFRepository<BillDetail, int>, IBillDetailRepository
    {
        public BillDetailRepository(AppDbContext context) : base(context)
        {
        }
    }
}