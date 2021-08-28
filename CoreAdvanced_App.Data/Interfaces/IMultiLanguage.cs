using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { get; set; }
    }
}
