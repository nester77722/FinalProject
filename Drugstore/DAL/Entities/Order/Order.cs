using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Order
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        [ForeignKey("UserName")]
        [Required]
        public string UserName { get; set; }
        public IdentityUser User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
