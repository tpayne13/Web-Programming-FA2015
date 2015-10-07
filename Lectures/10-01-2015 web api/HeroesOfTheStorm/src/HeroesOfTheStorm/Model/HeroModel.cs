
using System.ComponentModel.DataAnnotations;

namespace HeroesOfTheStorm.Model
{
	public class HeroModel
    {
		[Required]
		[MinLength(1)]
		public string Name { get; set; }

		[Required]
		[MinLength(1)]
		public string Universe { get; set; }

		[Required]
		[Range(100, 1000)]
		public int StartingHealth { get; set; }
    }
}
