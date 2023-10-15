using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Common
{


    public enum StatusFood
    {
        PENDING,
        ACCEPTED,
        REJECTED
    }

    public enum StatusOder
    {
        PENDING,
        CONFIRMED,
        OUT_FOR_DELIVERY,
        DELIVERED,
        CANCELLED,
    }

}
