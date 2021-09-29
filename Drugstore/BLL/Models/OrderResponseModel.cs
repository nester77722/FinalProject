using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class OrderResponseModel
    {
        public IEnumerable<OrderModel> Orders { get; set; }
        public int TotalOrders { get; set; }
    }
}
