using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobileBackend.Data;
using MobileBackend.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MobileBackend.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly DataContext _dbContext;
        public OrdersController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Order> Get()
        {
            return _dbContext.Orders.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _dbContext.Orders.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<controller>
        [HttpPost]
        public Order Post([FromBody]Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return order;
        }

        // PUT api/<controller>
        [HttpPut]
        public void Put([FromBody]Order order)
        {
            _dbContext.Orders.Update(order);
            _dbContext.SaveChanges();

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dbContext.Orders.Remove(new Order { Id = id});
        }
    }
}
