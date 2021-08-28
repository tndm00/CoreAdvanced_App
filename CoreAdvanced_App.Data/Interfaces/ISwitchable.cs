using CoreAdvanced_App.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
