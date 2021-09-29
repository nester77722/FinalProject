using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }
        public ICollection<OrderItemModel> OrderItems { get; set; }
    }
}
