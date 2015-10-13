using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LordOfTheRings.Services;

namespace LordOfTheRings.Controllers
{
    [Route("api/[controller]")]
    public class LordController : Controller
    {
		private static ILoggingService logger;

		public LordController(ILoggingService logger)
		{
			LordController.logger = logger;
		}

        [HttpGet]
        public IEnumerable<string> Get()
        {
			logger.Log("Called GET!");


            return new string[] { "value1", "value2" };
        }

        
    }
}
