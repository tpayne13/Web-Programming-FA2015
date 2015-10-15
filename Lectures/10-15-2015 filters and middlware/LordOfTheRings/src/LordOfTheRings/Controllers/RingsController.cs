using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LordOfTheRings.Services;
using System.Threading;

namespace LordOfTheRings.Controllers
{
    [Route("api/[controller]")]
    public class RingsController : Controller
    {
		private ILoggingService logger;

		public RingsController(ILoggingService logger)
		{
			this.logger = logger;
		}

        [HttpGet]
        public Ring Get()
        {
			logger.Log("Called GET!");

			return new Ring()
			{
				Name = "Gandalf's Ring",
				Set = "Elves"
			};
        }

        
		public class Ring
		{
			public string Name { get; set; }
			public string Set { get; set; }
		}
    }
}
