using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public class StoreModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<StockModel> Stocks { get; set; }
    }
}
