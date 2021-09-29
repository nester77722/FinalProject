using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Store
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Stock> Stocks { get; set; }
    }
}
