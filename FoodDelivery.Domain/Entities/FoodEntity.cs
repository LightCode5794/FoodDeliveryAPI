using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    
    public class FoodEntity : BaseAuditableEntity
    {
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "Money")]
        public required decimal  OriginalPrice { get; set; } = 0;
      
        public required ICollection<FoodImageEntity> Images { get; set; }

        [EnumDataType(typeof(StatusFood))]
        public  StatusFood Status { get; set; } = StatusFood.PENDING;

        public required FoodStoreEntity Store { get; set; }
        
        public ICollection<UserEntity>? FavoriteUsers { get; set; }

        public ICollection<FoodReviewEntity>? UserReviews { get; set; }

        public ICollection<CouponEntity>? Coupons { get; set; }

        public ICollection<OderDetailEntity>? OdersLink { get; set; }

    }



}
