using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Brand
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
