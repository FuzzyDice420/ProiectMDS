using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;
using ProiectMDS.Contexts;

namespace ProiectMDS.Repositories.ProviderRepository
{
    public class ProviderRepository : IProviderRepository
    {
        public Context _context { get; set; }
        public ProviderRepository(Context context)
        {
            _context = context;
        }
        public Provider Create(Provider providers)
        {
            var result = _context.Add<Provider>(providers);
            _context.SaveChanges();
            return result.Entity;
        }
        public Provider Get(int Id)
        {
            return _context.Providers.SingleOrDefault(x => x.Id == Id);
        }

        public List<Provider> GetAll()
        {
            return _context.Providers.ToList();
        }

        public Provider Update(Provider providers)
        {
            _context.Entry(providers).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return providers;
        }

        public Provider Delete(Provider providers)
        {
            var result = _context.Remove(providers);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
