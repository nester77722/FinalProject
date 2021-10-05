using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.ViewModels.Order
{
    public class OrderViewModel
    {
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<OrderItemViewModel> OrderItems { get; set; }
    }
}
