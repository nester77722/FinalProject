using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class ProductImageModel
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int ProductId { get; set; }
    }
}
