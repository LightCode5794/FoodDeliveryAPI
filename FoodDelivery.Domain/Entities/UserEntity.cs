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
    
        [Column(TypeName = "varchar(256)")]
        public  string Email { get; set; } = string.Empty;

        [Column(TypeName = "varchar(256)")]
        public required string Name { get; set; } 

        [Column(TypeName = "varchar(128)")]
   
        public required string Password { get; set; }

        [Column(TypeName = "varchar(128)")]
       
        public required string Phone_number { get; set; } 

        [Column(TypeName = "varchar(128)")]
        public string Avatar { get; set; } = string.Empty;

        [Column(TypeName = "varchar(256)")]
        public required string Address { get; set; } = string.Empty;
        public required RoleEntity Role { get; set; }

        public ICollection<FoodEntity>? FavoriteFoods { get; set; }
    }
}
