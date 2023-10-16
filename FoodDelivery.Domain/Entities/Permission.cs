using FoodDelivery.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Domain.Entities
{
    public class Permission : BaseAuditableEntity
    {
        public required string? Name { get; set; }

        public ICollection<Role>? Roles { get; set; }
        // Thay đổi tên bảng phụ
        public string RelationName = "RolePermission";
    }
}
