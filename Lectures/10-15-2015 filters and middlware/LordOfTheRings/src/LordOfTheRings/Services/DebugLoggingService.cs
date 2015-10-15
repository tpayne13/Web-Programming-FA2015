using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LordOfTheRings.Services
{
    public class DebugLoggingService : ILoggingService
    {
		public void Log(string message)
		{
			Debug.WriteLine(message);
		}
    }
}
