using ManagementBlock.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManagementBlock.Application.ViewModels
{
    public class MenuViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Url { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(255)]

        public string Css { get; set; }


        public int SortNumber { get; set; }
        public Status Status { get; set; }
    }
}
