using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class ShopStock
    {
        public int Id { get; set; }
        public int ComponentId { get; set; }
        public int ShopId { get; set; }
        public virtual Component Component { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
