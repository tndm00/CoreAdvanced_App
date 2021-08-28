using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { get; set; }
    }
}
