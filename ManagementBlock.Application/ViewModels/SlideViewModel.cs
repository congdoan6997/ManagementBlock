using ManagementBlock.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManagementBlock.Application.ViewModels
{
    public class SlideViewModel
    {
        public int Id { get; set; }

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
