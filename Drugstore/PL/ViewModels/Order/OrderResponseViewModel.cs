using PL.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.ViewModels
{
    public class OrderResponseViewModel
    {
        public IEnumerable<OrderViewModel> Orders { get; set; }
        public int TotalOrders { get; set; }
        
    }
}
