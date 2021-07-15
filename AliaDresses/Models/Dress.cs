using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaDresses.Models
{
    public class Dress
    {
        public int DressId { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThumbnailurl { get; set; }
        public bool InStock { get; set; }
        public bool IsDressOfTheWeek { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } 

    }
}
