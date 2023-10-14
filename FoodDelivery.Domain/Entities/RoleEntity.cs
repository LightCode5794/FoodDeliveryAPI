using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class RoleEntity : BaseAuditableEntity
    {
        [Column(TypeName = "varchar(128)")]
        public required string Name { get; set; }
        public ICollection<UserEntity>? Users { get; set; }
        public ICollection<RoleEntity>? Roles { get; set; }

    }
}
