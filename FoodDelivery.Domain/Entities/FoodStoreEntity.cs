﻿using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class FoodStoreEntity : BaseAuditableEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; } = string.Empty;
        public required string Address { get; set; }
    }
}
