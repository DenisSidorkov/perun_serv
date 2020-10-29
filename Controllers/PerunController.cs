using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace perun_serv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerunController : ControllerBase
    {
        //// GET: api/<PerunController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Perun kruto" };
        //}

        // GET api/<PerunController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            id = id - (int)(id * 0.04);
            return id.ToString();
        }

        // POST api/<PerunController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PerunController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PerunController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
