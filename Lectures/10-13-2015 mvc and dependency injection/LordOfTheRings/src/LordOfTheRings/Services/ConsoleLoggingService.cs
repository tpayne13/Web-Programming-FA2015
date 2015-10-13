using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LordOfTheRings.Services
{
    public class ConsoleLoggingService : ILoggingService
    {
		public ConsoleLoggingService(StringService service)
		{

		}

		public void Log(string message)
		{
			Console.WriteLine(message);
		}
    }
}
