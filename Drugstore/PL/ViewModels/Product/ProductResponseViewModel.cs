using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.ViewModels
{
    public class ProductResponseViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public int TotalProducts { get; set; }
    }
}
