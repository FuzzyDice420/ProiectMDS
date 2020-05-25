using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories;
using ProiectMDS.Repositories.ComponentCartRepository;
using ProiectMDS.Repositories.ComponentsRepository;
using ProiectMDS.Repositories.ShoppingCartRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        public IComponentRepository IComponentRepository { get; set; }

        public IShoppingCartRepository IShoppingCartRepository { get; set; }

        public IComponentCartRepository IComponentCartRepository { get; set; }

        public ShoppingCartController(IComponentRepository componentRepository, IShoppingCartRepository shoppingCartRepository, IComponentCartRepository componentCartRepository)
        {
            IComponentRepository = componentRepository;
            IShoppingCartRepository = shoppingCartRepository;
            IComponentCartRepository = componentCartRepository;
        }

        // GET: api/ShoppingCart
        [HttpGet]
        public ActionResult<IEnumerable<ShoppingCart>> Get()
        {
            return IShoppingCartRepository.GetAll();
        }

        // GET: api/ShoppingCart/5
        [HttpGet("{id}")]
        public ShoppingCartDTO Get(int id)
        {
            ShoppingCart shoppingCart = IShoppingCartRepository.Get(id);
            ShoppingCartDTO myShoppingCart = new ShoppingCartDTO()
            {
                TotalPrice = shoppingCart.TotalPrice
            };
            IEnumerable<ComponentCart> compCartList = IComponentCartRepository.GetAll().Where(p => p.ShoppingCartId == shoppingCart.Id);
            if (compCartList != null)
            {
                List<Component> compList = new List<Component>();
                foreach (ComponentCart myCompCart in compCartList)
                {
                    Component myComp = IComponentRepository.GetAll().SingleOrDefault(p => p.Id == myCompCart.ComponentId);
                    compList.Add(myComp);
                }
                myShoppingCart.Components = compList;
            }
            return myShoppingCart;
        }

        // POST: api/ShoppingCart
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ShoppingCart/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
