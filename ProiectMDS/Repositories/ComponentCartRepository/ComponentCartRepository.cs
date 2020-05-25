using ProiectMDS.Contexts;
using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Repositories.ComponentCartRepository
{
    public class ComponentCartRepository : IComponentCartRepository
    {
        public Context _context { get; set; }

        public ComponentCartRepository(Context context)
        {
            _context = context;
        }

        public ComponentCart Create(ComponentCart compcart)
        {
            var result = _context.Add<ComponentCart>(compcart);
            _context.SaveChanges();
            return result.Entity;
        }

        public ComponentCart Delete(ComponentCart compcart)
        {
            var result = _context.Remove(compcart);
            _context.SaveChanges();
            return result.Entity;
        }

        public ComponentCart Get(int id)
        {
            return _context.ComponentCarts.SingleOrDefault(x => x.Id == id);
        }

        public List<ComponentCart> GetAll()
        {
            return _context.ComponentCarts.ToList();
        }

        public ComponentCart Update(ComponentCart compcart)
        {
            _context.Entry(compcart).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return compcart;
        }
    }
}
