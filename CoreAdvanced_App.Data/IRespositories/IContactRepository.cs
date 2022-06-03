using CoreAdvanced_App.Data.Entities;
using CoreAdvanced_App.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.IRespositories
{
    public interface IContactRepository  :           IRepository<Contact, string>
    {
    }
}
