using ManagementBlock.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManagementBlock.Application.ViewModels
{
    public class BrandViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Image { get; set; }


        public Status Status { get; set; }
        public int SortNumber { get; set; }
    }
}
