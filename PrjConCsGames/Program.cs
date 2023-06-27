using PrjConCsGames;

namespace PrjConCsgames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //bool isChar;
            //char selection;
            
            //do
            //{
            //    Console.WriteLine("Games Menu:");
            //    Console.WriteLine("\n1 - Guess the number");
            //    Console.Write("\nPlease, choose your game: ");

            //    isChar = char.TryParse(Console.ReadLine(), out selection);
            //    Console.Clear();

            //} while (!(isChar && selection == '1'));
            
            GuessTheNumber.Play(); 
            
        }
    }

}

