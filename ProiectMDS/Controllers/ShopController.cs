using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ShopRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        public IShopRepository IShopRepository { get; set; }

        public ShopController(IShopRepository repository)
        {
            IShopRepository = repository;
        }

        // GET: api/<ShopController>
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get()
        {
            return IShopRepository.GetAll();
        }

        // GET api/<ShopController>/5
        [HttpGet("{id}")]
        public Shop Get(int id)
        {
            return IShopRepository.Get(id);
        }

        // POST api/<ShopController>
        [HttpPost]
        public Shop Post(ShopDTO value)
        {
            Shop model = new Shop()
            {
                Name = value.Name,
                Email = value.Email,
                Tel = value.Tel,
                Address = value.Address
            };
            return IShopRepository.Create(model);
        }

        // PUT api/<ShopController>/5
        [HttpPut("{id}")]
        public Shop Put(int id, ShopDTO value)
        {
            Shop model = IShopRepository.Get(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
            }
            if (value.Email != null)
            {
                model.Email = value.Email;
            }
            if (value.Tel != null)
            {
                model.Tel = value.Tel;
            }
            if (value.Address != null)
            {
                model.Address = value.Address;
            }
            return IShopRepository.Update(model);
        }

        // DELETE api/<ShopController>/5
        [HttpDelete("{id}")]
        public Shop Delete(int id)
        {
            Shop shop = IShopRepository.Get(id);
            return IShopRepository.Delete(shop);
        }
    }
}
