using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class FoodReviewEntity : BaseAuditableEntity
    {

        public required int UserId { get; set; }
        public required string FoodId  { get; set; }
        public required string Content { get; set; }

        [Range(1, 5)]
        public required int Rating { get; set; }

        public ICollection<ReviewImageEntity>? Images { get; set; }
        public required UserEntity User { get; set; }
        public required FoodEntity Food { get; set; }

    }
    
}
