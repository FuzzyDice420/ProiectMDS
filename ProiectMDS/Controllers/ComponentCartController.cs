using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ProiectMDS.DTOs;
using ProiectMDS.Models;
using ProiectMDS.Repositories.ComponentCartRepository;

namespace ProiectMDS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentCartController : ControllerBase
    {
        public IComponentCartRepository IComponentCartRepository { get; set; }

        public ComponentCartController(IComponentCartRepository repository)
        {
            IComponentCartRepository = repository;
        }

        // GET: api/<ComponentCartController>
        [HttpGet]
        public ActionResult<IEnumerable<ComponentCart>> Get()
        {
            return IComponentCartRepository.GetAll();
        }

        // GET api/<ComponentCartController>/5
        [HttpGet("{id}")]
        public ComponentCart Get(int id)
        {
            return IComponentCartRepository.Get(id);
        }

        // POST api/<ComponentCartController>
        [HttpPost]
        public ComponentCart Post(ComponentCartDTO value)
        {
            ComponentCart model = new ComponentCart()
            {
                ComponentId = value.ComponentId,
                ShoppingCartId = value.ShoppingCartId
            };
            return IComponentCartRepository.Create(model);
        }

        // PUT api/<ComponentCartController>/5
        [HttpPut("{id}")]
        public ComponentCart Put(int id, ComponentCartDTO value)
        {
            ComponentCart model = IComponentCartRepository.Get(id);
            if (value.ComponentId != 0)
            {
                model.ComponentId = value.ComponentId;
            }
            if (value.ShoppingCartId != 0)
            {
                model.ShoppingCartId = value.ShoppingCartId;
            }
            return IComponentCartRepository.Update(model);
        }

        // DELETE api/<ComponentCartController>/5
        [HttpDelete("{id}")]
        public ComponentCart Delete(int id)
        {
            ComponentCart compCart = IComponentCartRepository.Get(id);
            return IComponentCartRepository.Delete(compCart);
        }
    }
}
