using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using ManagementBlock.Infrastructure.SharedKennel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("Menus")]
    public class Menu : DomainEntity<int>, ISwitchable, IHasSort
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]
        [Column(TypeName ="varchar(255)")]
        public string Css { get; set; }


        public int SortNumber { get; set; }
        public Status Status { get; set; }
    }
}
