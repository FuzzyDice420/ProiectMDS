using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ComponentsRepository
{
    public interface IComponentRepository
    {
        List<Component> GetAll();
        Component Get(int id);
        Component Create(Component components);
        Component Update(Component components);
        Component Delete(Component components);
    }
}
