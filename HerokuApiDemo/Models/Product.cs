using System;

namespace HerokuApiDemo.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool Enabled { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Description { get; set; }
    }
}