using ManagementBlock.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ManagementBlock.Application.ViewModels
{
    public class BillViewModel
    {
        public int Id { get; set; }

        [Required]
        public int Count { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public Guid UserId { get; set; }


        public ProductViewModel ProductViewModel { get; set; }

        public AppUserViewModel AppUserViewModel { get; set; }
    }
}
