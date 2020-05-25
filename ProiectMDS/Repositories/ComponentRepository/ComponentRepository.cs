using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.ComponentsRepository
{
    public class ComponentRepository: IComponentRepository
    {
        public Context _context { get; set; }
        public ComponentRepository(Context context)
        {
            _context = context;
        }
        public Component Create(Component components)
        {
            var result = _context.Add<Component>(components);
            _context.SaveChanges();
            return result.Entity;
        }
        public Component Get(int Id)
        {
            return _context.Components.SingleOrDefault(x => x.Id == Id);
        }

        public List<Component> GetAll()
        {
            return _context.Components.ToList();
        }

        public Component Update(Component components)
        {
            _context.Entry(components).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return components;
        }

        public Component Delete(Component components)
        {
            var result = _context.Remove(components);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
