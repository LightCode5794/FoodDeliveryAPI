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
    public class FoodReview : BaseAuditableEntity
    {

        public required int UserId { get; set; }
        public required int FoodId  { get; set; }
        public required string Content { get; set; }

        [Range(1, 5)]
        public required int Rating { get; set; }

        //public ICollection<ReviewImageEntity>? Images { get; set; }
        public string[]? Images { get; set; }
        public required User User { get; set; }
        public required Food Food { get; set; }

    }
    
}
