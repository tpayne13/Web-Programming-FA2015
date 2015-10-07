using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using HeroesOfTheStorm.Model;
using System.Net;

namespace HeroesOfTheStorm.Controllers
{
	[Route("api/[controller]")]
    public class HeroesController : Controller
    {
		private static List<HeroModel> heroes = new List<HeroModel>();

        // GET: api/heroes
        [HttpGet]
        public IEnumerable<HeroModel> Get()
        {
			return heroes;
        }

        // GET api/heroes/5
        [HttpGet("{id}")]
        public HeroModel Get(int id)
        {
			if (id < 0 || id >= heroes.Count)
			{
				Response.StatusCode = (int)HttpStatusCode.BadRequest;
				return null;
			}
            return heroes[id];
        }

        // POST api/heroes
        [HttpPost]
        public HeroModel Post([FromBody]HeroModel hero)
        {
			if (!ModelState.IsValid)
			{
				Response.StatusCode = (int)HttpStatusCode.BadRequest;
				return null;
			}

			heroes.Add(hero);
			return hero;
        }

		// PATCH /api/heroes/5
		[HttpPatch("{id}")]
		public HeroModel Patch(int id, [FromBody] HeroModel hero)
		{
			if (!ModelState.IsValid)
			{
				Response.StatusCode = (int)HttpStatusCode.BadRequest;
				return null;
			}

			if (id < 0 || id >= heroes.Count)
			{
				Response.StatusCode = (int)HttpStatusCode.BadRequest;
				return null;
			}
			heroes[id] = hero;

			return hero;
		}


		private void Parsing()
		{
			string toParse = "fifty";

			// will throw exception
			var mynewint = int.Parse(toParse);

			int myBetterInt;
			if (int.TryParse(toParse, out myBetterInt))
			{
				// parsed correctly
			} else
			{
				// did not
			}

		}
    }
}
