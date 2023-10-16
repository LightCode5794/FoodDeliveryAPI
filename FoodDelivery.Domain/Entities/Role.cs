using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class Role : BaseAuditableEntity
    {
        public required string Name { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<Permission>? Permissions { get; set; }
       

    }
}
