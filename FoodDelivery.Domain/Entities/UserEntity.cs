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
        public new int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(256)")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "varchar(256)")]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "varchar(128)")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column(TypeName = "varchar(256)")]
        public string Avatar { get; set; } = string.Empty;
        

        [Column(TypeName = "varchar(256)")]
        public string Address { get; set; } = string.Empty;

        [Column(TypeName = "int")]
        public int RoleId { get; set; } 
    }
}
