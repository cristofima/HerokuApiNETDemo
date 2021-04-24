using System;
using System.ComponentModel.DataAnnotations;

namespace HerokuApiDemo.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Stock { get; set; }

        public bool Enabled { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }
    }
}