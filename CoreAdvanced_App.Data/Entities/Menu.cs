using CoreAdvanced_App.Data.Enums;
using CoreAdvanced_App.Data.Interfaces;
using CoreAdvanced_App.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreAdvanced_App.Data.Entities
{
    [Table("Menus")]
    public class Menu : DomainEntity<int>, IHasSoftDelete, ISwitchable, IDateTracking, ISortable
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        public string Css { get; set; }

        public int? PartentId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int SortOrder { get; set; }
        public bool IsDelete { get; set; }
        public Status Status { get; set; }
    }
}