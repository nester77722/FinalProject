using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductResponse
    {
        public IEnumerable<Product> Products { get; set; }
        public int TotalProducts { get; set; }
    }
}
