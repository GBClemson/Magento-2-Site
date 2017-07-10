using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeedPark_01.Models
{
    public class Products
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Tagline { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        public string ImageLink { get; set; }
    }
}
