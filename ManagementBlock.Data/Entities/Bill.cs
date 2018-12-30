using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using ManagementBlock.Infrastructure.SharedKennel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("Bills")]
    public class Bill : DomainEntity<int>, ISwitchable, IDateTracking
    {
        [Required]
        public int Count { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }

        public DateTime DateCreated { get  ; set  ; }
        public DateTime DateModified { get  ; set  ; }
        public Status Status { get  ; set  ; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public Guid UserId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }
    }
}
