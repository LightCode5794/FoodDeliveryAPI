using FoodDelivery.Domain.Common;
using FoodDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Application.Features.Users.Commands.CreateUser
{
    public class UserCreatedEvent : BaseEvent
    {
        public User User { get; }

        public UserCreatedEvent(User user)
        {
            User = user;
        }
    }
}
