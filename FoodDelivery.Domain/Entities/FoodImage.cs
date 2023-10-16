using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class FoodImage : BaseAuditableEntity
    {
        public string Url { get; set; } = string.Empty;
        public required Food FoodReview { get; set; }
    }
}
