using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class StoreResponseModel
    {
        public IEnumerable<StoreModel> Stores { get; set; }
        public int TotalStores { get; set; }
    }
}
