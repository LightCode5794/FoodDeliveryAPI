using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class Coupon : BaseAuditableEntity
    {
        public required string Title { get; set; }
        public string? Images { get; set; } = string.Empty;

        [Column(TypeName = "Money")]
        public required decimal MinCost { get; set; } = 0;
        [Column(TypeName = "Money")]
        public required decimal MaxCost { get; set; } = 0;
        public  decimal? Percent { get; set; }

        [Column(TypeName = "Money")]
        public decimal Discount { get; set; } = 0;
        public DateTime StartDay { get; set; } = DateTime.Now;
        public DateTime EndDay { get; set; }
        public required FoodStore FoodStore { get; set; }
        public ICollection<Food>? Foods { get; set; }

    }
}
