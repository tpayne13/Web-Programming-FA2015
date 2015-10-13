using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LordOfTheRings.Services
{
    public class MySingleton
    {
		private MySingleton()
		{

		}

		public static MySingleton Instance { get; set; }

		static MySingleton()
		{
			Instance = new MySingleton();
		}
    }
}
