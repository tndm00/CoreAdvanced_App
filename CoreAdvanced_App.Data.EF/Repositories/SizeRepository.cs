using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class SizeRepository : EFRepository<Size, int>, ISizeRepository
    {
        public SizeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
