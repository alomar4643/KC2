using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace KC2
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many Movies do you want to add?");
			var numberOfRecords = int.Parse(Console.ReadLine());

			var recordList = new List<ComedyMovies>();
			for (int i = 0; i < numberOfRecords; i++)
			{
				// In this loop, populate the object's properties using Console.ReadLine()
				var comedyMovies = new ComedyMovies();

				Console.WriteLine("Enter the name of the Movie.");
				comedyMovies.Name = Console.ReadLine();

				Console.WriteLine("Enter the category of movie you're watching.");
				comedyMovies.Description = (Console.ReadLine());

				Console.WriteLine("Enter the lenght of the movie in minutes.");
				comedyMovies.LengthMinutes = int.Parse(Console.ReadLine());

				Console.WriteLine("Is this a comedy movie? (True or False)");
				comedyMovies.IsComedyMovie = bool.Parse(Console.ReadLine());

				recordList.Add(comedyMovies);
			}

			// Print out the list of records using Console.WriteLine()
			Console.WriteLine();
		}
	}
}