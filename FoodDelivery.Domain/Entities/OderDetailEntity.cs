using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class OderDetailEntity : BaseAuditableEntity
    {
        public int OderId { get; set; }
        public int FoodId { get; set; }
        public required int Quantity { get; set; }
        public required FoodEntity Food { get; set; }
        public required OderEntity Oder { get; set; }

    }
}
