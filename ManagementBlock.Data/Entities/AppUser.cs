using ManagementBlock.Data.Enums;
using ManagementBlock.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementBlock.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, ISwitchable, IDateTracking
    {
        [StringLength(255)]
        
        public string FullName { get; set; }
        [StringLength(255)]
        public string Avatar { get; set; }
        [DefaultValue(0)]
        public decimal Money { get; set; }
        [StringLength(255)]
        public string Room { get; set; }
        public DateTime? Birthday { get; set; }
        public int NumberGroup { get; set; }
        [StringLength(255)]
        public string Faculty { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
