using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagementBlock.Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        public int Count { get; set; }
        [StringLength(255)]
        public string Room { get; set; }

        public int NumberGroup { get; set; }
        [StringLength(255)]
        public string Faculty { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }

    }
}
