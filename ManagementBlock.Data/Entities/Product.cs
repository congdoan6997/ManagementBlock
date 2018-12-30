using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using ManagementBlock.Infrastructure.SharedKennel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking
    {
        public Product()
        {
            Bills = new List<Bill>();
        }
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

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
