using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities.Order
{
    public class OrderResponse
    {
        public IEnumerable<Order> Orders { get; set; }
        public int TotalOrders { get; set; }
    }
}
