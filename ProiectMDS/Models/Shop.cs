﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public List<ShopStock> ShopStock { get; set; }
    }
}
