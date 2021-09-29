using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ProductResponseModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
        public int TotalProducts { get; set; }
    }
}
