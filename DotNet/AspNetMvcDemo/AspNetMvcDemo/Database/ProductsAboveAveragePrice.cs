﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AspNetMvcDemo.Database
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
