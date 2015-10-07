using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace AssignmentThreeClient
{
	public class Program
	{
		public void Main(string[] args)
		{
			string choice = "";
			while (choice != "GET" && choice != "POST")
			{
				Console.Write("GET or POST? ");
				choice = Console.ReadLine().ToUpperInvariant();
			}

			if (choice == "GET")
			{
				var request = WebRequest.Create("http://webprogrammingassignment3.azurewebsites.net/api/starWars");
				request.Method = "GET";

				var response = request.GetResponse();

				var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

				Console.WriteLine("Response: " + responseString);
			} else if (choice == "POST")
			{
				var request = WebRequest.Create("http://webprogrammingassignment3.azurewebsites.net/api/starWars");
				request.Method = "POST";
				request.ContentType = "application/json";

				var requestStream = request.GetRequestStream();
				var writer = new StreamWriter(requestStream);
				writer.WriteLine(JsonConvert.SerializeObject(
					new StarWarsCharacter() { FirstName = "Steven", Character = "Luke 2" }));
				writer.Close();

				var response = request.GetResponse();

				var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

				Console.WriteLine("Response: " + responseString);
			}

			Console.ReadLine();

		}
	}

	public class StarWarsCharacter
	{
		public string FirstName { get; set; }

		public string Character { get; set; }
	}
}
