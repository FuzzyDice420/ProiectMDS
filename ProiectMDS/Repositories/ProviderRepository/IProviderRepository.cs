using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectMDS.Models;

namespace ProiectMDS.Repositories.ProviderRepository
{
    public interface IProviderRepository
    {
        List<Provider> GetAll();
        Provider Get(int id);
        Provider Create(Provider providers);
        Provider Update(Provider providers);
        Provider Delete(Provider providers);
    }
}