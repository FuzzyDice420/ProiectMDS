using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Models
{
    public class ComponentCart
    {
        public int Id { get; set; }

        public int ComponentId { get; set; }

        public int ShoppingCartId { get; set; }

        public virtual Component Component { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
