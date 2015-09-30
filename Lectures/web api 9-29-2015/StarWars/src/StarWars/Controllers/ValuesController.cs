using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Net;

namespace StarWars.Controllers
{

    [Route("api/[controller]")]
    public class StarwarsController : Controller
    {
		public const int NUMBER_OF_TIMES = 400;

		public List<string> values = new List<string>() { "Steven" };

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
			return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
			if (id < 0 || id >= values.Count)
			{
				Response.StatusCode = (int) HttpStatusCode.NotFound;
				return "Your index was out of range.";
				//var result = new ContentResult();

				//return new ContentResult() { StatusCode = 404 };
			}
			//return new ContentResult() { Content = values[id] };

			return values[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
			if (value == null || value.Length == 0)
			{
				Response.StatusCode = 400;
				return;
			}
			values.Add(value);
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

		[HttpGet]
		[Route("/")]
		public StarWarsCharacter GetStarWars()
		{

			return new StarWarsCharacter() {Name = "Steven", Character = "Luke" };
		}
    }

	public class StarWarsCharacter
	{
		public string Name { get; set; }
		public string Character { get; set; }
	}
}
