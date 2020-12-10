using API_REST.Contexts;
using API_REST.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST.Controllers
{
    [Route("api/[controller]")]
  
    public class HistorialController : ControllerBase
    {
        private readonly AppDbContext context;

        public HistorialController(AppDbContext context)
        {
            this.context = context;
        }
      

        // GET: api/<HistorialController>
        [HttpGet]
        public IEnumerable<Historial> Get()
        {
            return context.Historial.ToList();
        }


        // GET api/<HistorialController>/5
        [HttpGet("{id}")]
        public Historial Get(string id)
        {
            var historial = context.Historial.FirstOrDefault(p=>p.Documento==id);
            return historial;


        }

        // POST api/<HistorialController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HistorialController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HistorialController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
