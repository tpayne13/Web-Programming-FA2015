using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryPotter.Models
{
	public class IngredientModel
	{
		public string Name { get; set; }
	}

	public class IngredientsModel
	{
		public IngredientsModel()
		{
			All = new List<IngredientModel>()
				{
					new IngredientModel() {Name = "Banana" },
					new IngredientModel() {Name = "Pear" },
					new IngredientModel() {Name = "Strawberry" },
					new IngredientModel() {Name = "Apple" }
				};
		}
		public List<IngredientModel> All { get; set; }
	}
}
