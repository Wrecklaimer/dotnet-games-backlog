using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GamesBacklog.Web.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
                "value1",
                "value2"
            };
        }

        // GET api/<controller>/5
        [HttpGet("{id:int}")]
        public string Get(int id)
        {
            return $"value{id}";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }
    }
}
