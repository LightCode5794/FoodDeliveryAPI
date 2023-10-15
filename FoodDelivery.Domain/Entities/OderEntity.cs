using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
   
    public class OderEntity : BaseAuditableEntity
    {
        public required string Address { get; set; }
        
        [EnumDataType(typeof(StatusOder))]
        public StatusOder Status { get; set; } = StatusOder.PENDING;

        public ICollection<OderDetailEntity>? FoodsLink { get; set; }

        public ICollection<NotificationEntity>? Notifications { get; set; }
    }
}
