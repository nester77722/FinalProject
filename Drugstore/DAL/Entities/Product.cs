using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        [Required]
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
