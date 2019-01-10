using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using ManagementBlock.Infrastructure.SharedKennel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("Menus")]
    public class Menu : DomainEntity<string>, ISwitchable, IHasSort
    {
        public Menu()
        {

        }

        public Menu(string name, string url, string parentId, string iconCss, int sortOrder)
        {
            this.Name = name;
            this.Url = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SortNumber = sortOrder;
            this.Status = Status.Active;
        }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Url { get; set; }


        [StringLength(255)]
        [Column(TypeName = "varchar(255)")]
        public string IconCss { get; set; }
        [StringLength(255)]
        public string ParentId { get; set; }
        public int SortNumber { get; set; }
        public Status Status { get; set; }
    }
}
