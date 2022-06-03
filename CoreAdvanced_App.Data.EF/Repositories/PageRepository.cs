using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class PageRepository : EFRepository<Page, int>, IPageRepository
    {
        public PageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
