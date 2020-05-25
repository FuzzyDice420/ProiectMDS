using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ShoppingCartRepository
{
    public interface IShoppingCartRepository
    {
        List<ShoppingCart> GetAll();
        ShoppingCart Get(int id);
        ShoppingCart Create(ShoppingCart shoppingCarts);
        ShoppingCart Update(ShoppingCart shoppingCarts);
        ShoppingCart Delete(ShoppingCart shoppingCarts);
    }
}
