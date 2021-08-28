using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }

        DateTime DateModified { get; set; }
    }
}
