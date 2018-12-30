using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using ManagementBlock.Infrastructure.SharedKennel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>, ISwitchable, IHasSort
    {
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        public string Text { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public Status Status { get; set; }
        public int SortNumber { get; set; }
    }
}
