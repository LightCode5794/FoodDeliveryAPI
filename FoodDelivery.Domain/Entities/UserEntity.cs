using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class UserEntity : BaseAuditableEntity
    {
    
        public  string Email { get; set; } = string.Empty;
  
        public required string Name { get; set; } 
         
        public required string Password { get; set; }
      
        public required string Phone_number { get; set; } 
       
        public string Avatar { get; set; } = string.Empty;
   
        public required string Address { get; set; } = string.Empty;
        public required RoleEntity Role { get; set; }

        public ICollection<FoodEntity>? FavoriteFoods { get; set; }

        public ICollection<FoodReviewEntity>? FoodReviews { get; set; }

    }
}
