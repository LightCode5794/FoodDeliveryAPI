using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class OderDetail : BaseAuditableEntity
    {
        public int OderId { get; set; }
        public int FoodId { get; set; }
        public required int Quantity { get; set; }
        public required Food Food { get; set; }
        public required Oder Oder { get; set; }

    }
}
