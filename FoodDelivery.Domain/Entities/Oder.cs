using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
   
    public class Oder : BaseAuditableEntity
    {
        public required string Address { get; set; }
        
        [EnumDataType(typeof(StatusOder))]
        public StatusOder Status { get; set; } = StatusOder.PENDING;

        public ICollection<OderDetail>? FoodsLink { get; set; }

        public ICollection<Notification>? Notifications { get; set; }
    }
}
