﻿using System;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DatedCreated { get; set; }
        public string SeoAlias { get; set; }

    }
}
