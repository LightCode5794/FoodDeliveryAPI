using FoodDelivery.Application.Common.Mappings;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Users.Queries.GetAllUsers
{
    public class UserDto : IMapFrom<User>
    {
        public string? Email { get; set; }

        public required string Name { get; set; }

        public required string Phone_number { get; set; }

        public string? Avatar { get; set; }

        public required string Address { get; set; } 
        //public required Role Role { get; set; }

        public ICollection<Food>? FavoriteFoods { get; set; }

        public ICollection<FoodReview>? FoodReviews { get; set; }
    }
}
