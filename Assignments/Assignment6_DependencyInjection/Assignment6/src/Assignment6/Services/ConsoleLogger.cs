using System;

namespace Assignment6.Services
{
	/*
	*	READ ONLY! This class should not be edited by you!
	*
	*	This class logs output to the console.
	*/
	public class ConsoleLogger
    {
		private static ConsoleLogger instance = new ConsoleLogger(); 

		public static ConsoleLogger Instance { get { return instance; } }

		public ConsoleLogger()
		{
			if (instance != null)
			{
				throw new InvalidOperationException("Tried to create a second ConsoleLogger. That's bad.");
			}
		}

		public void Log(string message)
		{
			Console.WriteLine(message);
		}
    }
}
