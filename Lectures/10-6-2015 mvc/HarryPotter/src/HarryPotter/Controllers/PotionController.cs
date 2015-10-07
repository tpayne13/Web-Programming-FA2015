using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HarryPotter.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HarryPotter.Controllers
{
    public class PotionController : Controller
    {
		private static IngredientsModel allIngredients = new IngredientsModel();

		// GET: /<controller>/
		public IActionResult Index()
        {
            return View(allIngredients);
        }

		[HttpPost]
		public IActionResult Mix()
		{
			string mixed;
			if (Request.HasFormContentType)
			{
				mixed = Request.Form["potion(0)"] + Request.Form["potion(1)"];
			}
			return null;
		}
    }
}
