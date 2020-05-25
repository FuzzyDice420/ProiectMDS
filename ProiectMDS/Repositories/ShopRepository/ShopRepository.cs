using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.ShopRepository
{
    public class ShopRepository : IShopRepository
    {
        public Context _context { get; set; }
        public ShopRepository(Context context)
        {
            _context = context;
        }
        public Shop Create(Shop shops)
        {
            var result = _context.Add<Shop>(shops);
            _context.SaveChanges();
            return result.Entity;
        }
        public Shop Get(int Id)
        {
            return _context.Shops.SingleOrDefault(x => x.Id == Id);
        }

        public List<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }

        public Shop Update(Shop shops)
        {
            _context.Entry(shops).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return shops;
        }

        public Shop Delete(Shop shops)
        {
            var result = _context.Remove(shops);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
