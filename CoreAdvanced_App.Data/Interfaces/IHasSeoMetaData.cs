using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreAdvanced_App.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        [StringLength(255)]
        string SeoPageTitle { get; set; }

        [Column(TypeName = "varchar(255)")]
        [StringLength(255)]
        string SeoAlias { get; set; }

        [StringLength(255)]
        string SeoKeywords { get; set; }

        [StringLength(255)]
        string SeoDescription { get; set; }
    }
}
