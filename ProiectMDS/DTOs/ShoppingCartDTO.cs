using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.DTOs
{
    public class ShoppingCartDTO
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }
        public List<Component> Components { get; set; }
    }
}
