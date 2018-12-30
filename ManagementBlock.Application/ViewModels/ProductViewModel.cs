using ManagementBlock.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagementBlock.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            BillViewModels = new List<BillViewModel>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Icon { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        public ICollection<BillViewModel> BillViewModels { get; set; }
    }
}
