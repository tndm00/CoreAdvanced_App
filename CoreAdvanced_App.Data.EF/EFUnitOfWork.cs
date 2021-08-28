using CoreAdvanced_App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _conext;
        public EFUnitOfWork(AppDbContext context)
        {
            _conext = context;
        }
        public void Commit()
        {
            _conext.SaveChanges();
        }

        public void Dispose()
        {
            _conext.Dispose();
        }
    }
}
