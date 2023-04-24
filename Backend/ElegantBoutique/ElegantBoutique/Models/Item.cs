using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantBoutique.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string? ImagesUrl { get; set; }
        public List<Image> Images { get; set; }
    }
}
