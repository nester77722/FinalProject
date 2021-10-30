using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Stock
    {
        public int Id { get; set; }
        [Required]
        public int StoreId { get; set; }
        public Store Store { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}
