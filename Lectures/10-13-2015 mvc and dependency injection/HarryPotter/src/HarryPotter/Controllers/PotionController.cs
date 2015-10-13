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
			if (Request.HasFormContentType)
			{
				var ingredients = Request.Form.GetValues("ingredients");
				if (ingredients != null && ingredients.Count == 2)
				{
					allIngredients.All.Add(new IngredientModel() { Name = ingredients[0] + ingredients[1] });
				}
			}
			return RedirectToAction("index");
		}

		public IActionResult Ingredient(int id)
		{
			if (id >= 0 && id < allIngredients.All.Count)
			{
				ViewBag.ingredientName = allIngredients.All[id].Name;
				ViewBag.ingredientIndex = id;
				return View();
			}

			return RedirectToAction("index");
		}

		[HttpPost]
		public IActionResult Delete()
		{
			if (Request.HasFormContentType)
			{
				var ingredient = Request.Form.Get("ingredientIndex");
				int id;
				if (ingredient != null && int.TryParse(ingredient, out id))
				{
					allIngredients.All.RemoveAt(id);
				}
			}

			return RedirectToAction("index");
		}
    }
}
