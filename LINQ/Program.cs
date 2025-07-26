using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>()
            {
                "The Legend of Zelda: Ocarina of Time",
                "Tetris",
                "Super Mario 64",
                "The Last of Us",
                "Red Dead Redemption 2",
                "Grand Theft Auto V",
                "The Witcher 3: Wild Hunt",
                "Half-Life 2",
                "Elden Ring",
                "Resident Evil 4"
            };

            games.OrderBy(x => x).ToList().ForEach(Console.WriteLine);
        }
    }
}
