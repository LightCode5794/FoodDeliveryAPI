using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class ReviewImage : BaseAuditableEntity
    {
        public string Url { get; set; } = string.Empty;
        public required FoodReview FoodReview { get; set; }
    }

}
