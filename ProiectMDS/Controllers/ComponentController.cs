using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ComponentsRepository;
using ProiectMDS.Repositories.ProviderRepository;
using ProiectMDS.Repositories.ShoppingCartRepository;
using ProiectMDS.Repositories.ShopRepository;
using ProiectMDS.Repositories.ShopStockRepository;



namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentController : ControllerBase
    {
        public IComponentRepository IComponentRepository { get; set; }
        public IProviderRepository IProviderRepository { get; set; }
        public IShoppingCartRepository IShoppingCartRepository { get; set; }
        public IShopRepository IShopRepository { get; set; }
        public IShopStockRepository IShopStockRepository { get; set; }

        public ComponentController(IComponentRepository componentRepository, IProviderRepository providerRepository, IShoppingCartRepository shoppingCartRepository, IShopRepository shopRepository, IShopStockRepository shopStockRepository)
        {
            IComponentRepository = componentRepository;
            IProviderRepository = providerRepository;
            IShoppingCartRepository = shoppingCartRepository;
            IShopRepository = shopRepository;
            IShopStockRepository = shopStockRepository;
        }

        // GET: api/Component
        [HttpGet]
        public ActionResult<IEnumerable<Component>> Get()
        {
            return IComponentRepository.GetAll();
        }

        // GET: api/Component/5
        [HttpGet("{id}")]
        public ComponentDetailsDTO Get(int id)
        {
            Component component = IComponentRepository.Get(id);
            ComponentDetailsDTO myComponent = new ComponentDetailsDTO()
            {
                Name = component.Name,
                Price = component.Price,
                Quantity = component.Quantity
            };
            Provider provider = IProviderRepository.Get(component.ProviderId);
            myComponent.ProviderName = provider.Name;
            return myComponent;
        }

            // POST: api/Component
            [HttpPost]
        public Component Post(ComponentDTO value)
        {
            Component model = new Component()
            {
                ProviderId = value.ProviderId,
                Name = value.Name,
                Price = value.Price,
                Quantity = value.Quantity
            };
            return IComponentRepository.Create(model);
        }

            // PUT: api/Component/5
            [HttpPut("{id}")]
        public Component Put(int id, ComponentDTO value)
        {
            Component model = IComponentRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            if (value.Price != 0)
            {
                model.Price = value.Price;
            }
            model.Quantity = value.Quantity;
            if (value.ProviderId != 0)
            {
                model.ProviderId = value.ProviderId;
            }
            return IComponentRepository.Update(model);
        }

            // DELETE: api/ApiWithActions/5
            [HttpDelete("{id}")]
        public Component Delete(int id)
        {
            Component component = IComponentRepository.Get(id);
            return IComponentRepository.Delete(component);
        }
    }

}
