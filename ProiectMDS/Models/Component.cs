using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class Component
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public List<ShopStock> ShopStock { get; set; }
    }
}
