using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.ShoppingCartRepository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        public Context _context { get; set; }
        public ShoppingCartRepository(Context context)
        {
            _context = context;
        }
        public ShoppingCart Create(ShoppingCart shoppingCarts)
        {
            var result = _context.Add<ShoppingCart>(shoppingCarts);
            _context.SaveChanges();
            return result.Entity;
        }
        public ShoppingCart Get(int Id)
        {
            return _context.ShoppingCarts.SingleOrDefault(x => x.Id == Id);
        }

        public List<ShoppingCart> GetAll()
        {
            return _context.ShoppingCarts.ToList();
        }

        public ShoppingCart Update(ShoppingCart shoppingCarts)
        {
            _context.Entry(shoppingCarts).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return shoppingCarts;
        }

        public ShoppingCart Delete(ShoppingCart shoppingCarts)
        {
            var result = _context.Remove(shoppingCarts);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
