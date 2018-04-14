using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP_WebBasic.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values 
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5?query=hello&id=23
        [HttpGet("{id}")]
        public string Get([FromQuery]int id, string query)
        {
            return $"value retrieved {id}, query value {query}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Value value)
        {
            if(!ModelState.IsValid){
                throw new InvalidOperationException("Invalid input");
            }   
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Value
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
