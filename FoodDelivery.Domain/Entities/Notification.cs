using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class Notification : BaseAuditableEntity
    {
        public required string Content { get; set; }
        public string Status { get; set; } = string.Empty;
        public ICollection<Oder>? Orders { get; set; }
    }
}
