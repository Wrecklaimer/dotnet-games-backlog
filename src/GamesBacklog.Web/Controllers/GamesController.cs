using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesBacklog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GamesBacklog.Web.Controllers
{
    [Route("api/[controller]")]
    public class GamesController : ControllerBase
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return new List<Game>() {
                new Game() {
                    Id = 1,
                    Title = "Super Mario Bros.",
                    ReleaseDate = new DateTime(1985, 9, 13),
                },
                new Game() {
                    Id = 2,
                    Title = "The Legend of Zelda",
                    ReleaseDate = new DateTime(1986, 2, 21),
                },
            };
        }

        // GET api/<controller>/5
        [HttpGet("{id:int}")]
        public Game Get(int id)
        {
            return new Game() {
                Id = id,
                Title = "Super Mario Bros.",
                ReleaseDate = new DateTime(1985, 9, 13),
            };
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
