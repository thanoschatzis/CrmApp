﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp.Models
{
    public class BasketProduct
    {
        public int Id { get; set; }
        public Basket Basket { get; set; }
        public Product Product { get; set; }
        
    }
}
