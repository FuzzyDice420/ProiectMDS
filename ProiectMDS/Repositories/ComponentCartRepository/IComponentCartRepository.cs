using ProiectMDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMDS.Repositories.ComponentCartRepository
{
    public interface IComponentCartRepository
    {
        List<ComponentCart> GetAll();

        ComponentCart Get(int id);

        ComponentCart Create(ComponentCart compcart);

        ComponentCart Update(ComponentCart compcart);

        ComponentCart Delete(ComponentCart compcart);
    }
}
