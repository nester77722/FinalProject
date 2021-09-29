using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PL.ViewModels
{
    public class StoreResponseViewModel
    {
        public IEnumerable<StoreViewModel> Stores { get; set; }
        public int TotalStores { get; set; }
    }
}
