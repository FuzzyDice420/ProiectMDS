using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.ShopStockRepository
{
    public class ShopStockRepository : IShopStockRepository
    {
        public Context _context { get; set; }
        public ShopStockRepository(Context context)
        {
            _context = context;
        }
        public ShopStock Create(ShopStock shopStocks)
        {
            var result = _context.Add<ShopStock>(shopStocks);
            _context.SaveChanges();
            return result.Entity;
        }
        public ShopStock Get(int Id)
        {
            return _context.ShopStocks.SingleOrDefault(x => x.ComponentId == Id);
        }

        public List<ShopStock> GetAll()
        {
            return _context.ShopStocks.ToList();
        }

        public ShopStock Update(ShopStock shopStocks)
        {
            _context.Entry(shopStocks).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return shopStocks;
        }

        public ShopStock Delete(ShopStock shopStocks)
        {
            var result = _context.Remove(shopStocks);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
