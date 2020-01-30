using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductInCategory
    {
        public Product Product { get; set; }

        public Category Category { get; set; }
    }
}
