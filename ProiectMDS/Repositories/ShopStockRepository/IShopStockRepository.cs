using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ShopStockRepository
{
    public interface IShopStockRepository
    {
        List<ShopStock> GetAll();
        ShopStock Get(int id);
        ShopStock Create(ShopStock shopStocks);
        ShopStock Update(ShopStock shopStocks);
        ShopStock Delete(ShopStock shopStocks);
    }
}
