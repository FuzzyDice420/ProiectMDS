using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ShopRepository
{
    public interface IShopRepository
    {
        List<Shop> GetAll();
        Shop Get(int id);
        Shop Create(Shop shops);
        Shop Update(Shop shops);
        Shop Delete(Shop shops);
    }
}
