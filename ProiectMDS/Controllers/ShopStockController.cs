using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ShopStockRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopStockController : ControllerBase
    {
        public IShopStockRepository IShopStockRepository { get; set; }

        public ShopStockController(IShopStockRepository shopStockRepository)
        {
            IShopStockRepository = shopStockRepository;
        }

        // GET: api/<ShopStockController>
        [HttpGet]
        public ActionResult<IEnumerable<ShopStock>> Get()
        {
            return IShopStockRepository.GetAll();
        }

        // GET api/<ShopStockController>/5
        [HttpGet("{id}")]
        public ShopStock Get(int id)
        {
            return IShopStockRepository.Get(id);
        }

        // POST api/<ShopStockController>
        [HttpPost]
        public ShopStock Post(ShopStockDTO value)
        {
            ShopStock model = new ShopStock()
            {
                ComponentId = value.ComponentId,
                ShopId = value.ShopId
            };
            return IShopStockRepository.Create(model);
        }

        // PUT api/<ShopStockController>/5
        [HttpPut("{id}")]
        public ShopStock Put(int id, ShopStockDTO value)
        {
            ShopStock model = IShopStockRepository.Get(id);
            if (value.ComponentId != 0)
            {
                model.ComponentId = value.ComponentId;
            }
            if (value.ComponentId != 0)
            {
                model.ComponentId = value.ComponentId;
            }
            return IShopStockRepository.Update(model);
        }

        // DELETE api/<ShopStockController>/5
        [HttpDelete("{id}")]
        public ShopStock Delete(int id)
        {
            ShopStock shopStock = IShopStockRepository.Get(id);
            return IShopStockRepository.Delete(shopStock);
        }
    }
}
