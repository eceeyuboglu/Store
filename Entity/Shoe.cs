using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public int ShoeNumber { get; set; }
        public int ColorId { get; set; }
        public string Gender { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int MaterialId { get; set; }
    }
}
