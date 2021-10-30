using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class StoreResponse
    {
        public IEnumerable<Store> Stores { get; set; }
        public int TotalStores { get; set; }
    }
}
