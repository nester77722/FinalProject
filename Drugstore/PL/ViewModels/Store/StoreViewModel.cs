using System.Collections.Generic;

namespace PL.ViewModels
{
    public class StoreViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<StockViewModel> Stocks { get; set; }
    }
}
