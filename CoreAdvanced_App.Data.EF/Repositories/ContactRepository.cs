using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Data.IRespositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.EF.Repositories
{
    public class ContactRepository:   EFRepository<Contact, string>, IContactRepository
    {
        public ContactRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
