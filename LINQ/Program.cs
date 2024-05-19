using Microsoft.VisualBasic;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>
            {"The Last of Us pt II",
             "The Last of Us",
             "The Legend of Zelda: Tears of the Kingdom",
             "Neir: Automata",
             "The Ghost of Tsushima",
            };

            Console.WriteLine("My top 5 favorite video games");
            Console.WriteLine("_______________________________");

            foreach (var game in videoGames)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("My top 5 favorite video games (sorted by length)");
            Console.WriteLine("_______________________________");

            var gamesByLength = videoGames.OrderBy(game => game.Length).ToList();

            foreach (var game in gamesByLength)
            {
                Console.WriteLine(game);
            }
        }
    }
}
