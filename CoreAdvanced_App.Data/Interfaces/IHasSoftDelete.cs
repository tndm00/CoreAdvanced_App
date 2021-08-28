using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDelete { get; set; }
    }
}
