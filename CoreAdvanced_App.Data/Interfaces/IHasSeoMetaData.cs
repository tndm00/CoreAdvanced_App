using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        [StringLength(255)]
        string SeoPageTitle { get; set; }

        [StringLength(255)]
        string SeoAlias { get; set; }

        [StringLength(255)]
        string SeoKeywords { get; set; }

        [StringLength(255)]
        string SeoDescription { get; set; }
    }
}
