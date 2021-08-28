using CoreAdvanced_App.Data.Enums;
using CoreAdvanced_App.Data.Interfaces;
using CoreAdvanced_App.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreAdvanced_App.Data.Entities
{
    [Table("Brands")]
    public class Brand : DomainEntity<int>, IDateTracking, IHasSoftDelete, ISwitchable
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        public bool IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
