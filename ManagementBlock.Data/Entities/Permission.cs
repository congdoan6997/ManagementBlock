using ManagementBlock.Infrastructure.SharedKennel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManagementBlock.Data.Entities
{
    [Table("Permissions")]
   public class Permission:DomainEntity<int>
    {
        public Guid RoleId { get; set; }

        public bool CanRead { get; set; }
        public bool CanEdit { get; set; }


        public bool CanDelete { get; set; }
        public bool CanCreate { get; set; }

        [ForeignKey("RoleId")]
        public virtual AppRole AppRole { get; set; }
    }
}
