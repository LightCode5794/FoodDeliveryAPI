using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public enum Status
    {
        PENDING,
        ACCEPTED,
        REJECTED
    }
    public class FoodEntity : BaseAuditableEntity
    {
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;

        [Column(TypeName = "Money")]
        public required decimal  OriginalPrice { get; set; } = 0;

        public  Status Status { get; set; } = Status.PENDING;

        public ICollection<UserEntity>? FavoriteUsers { get; set; }


    }
}
