namespace PrjConCsGames
{
    internal class GuessTheNumber
    {
        //TODO:
        //1 - Implement different levels
        //2 - Implement function to repeat the game or send back to game selection
        internal static void Play()
        {
            //SelectNivel();
            GameLoop();
        }

        private static void SelectNivel() 
        {
            char selection;
            bool isChar, isValid;
            char[] options = new char[] {'1', '2', '3'};

            do
            {
                Console.Clear();
                Console.WriteLine("Please, select the desired nivel:");
                Console.WriteLine("1 - Easy");
                Console.WriteLine("2 - Normal");
                Console.WriteLine("3 - Hard");

                isChar = char.TryParse(Console.ReadLine(), out selection);
                isValid = Array.Exists<char>(options, el => el == selection);

            } while (!isChar || !isValid);
        }

        private static void GameLoop()
        {
            short number = (short) new Random().Next(1, 10);
            short guess;

            List<short> guesses = new List<short>();
            short score = 1000;

            do
            {
                guess = AskGuess(score, guesses);

                guesses.Add(guess);

                Console.Clear();

               DisplayResult(guess, number);

            } while (guess != number);

        }

        private static short AskGuess( short score, List<short> guesses)
        {
            bool isShort;
            short guess;
            do
            {
                Console.WriteLine("\t===================================");
                Console.WriteLine("\t        GUESS A NUMBER!\n");
                Console.WriteLine($"\tScore:{score}");
                Console.WriteLine($"\tPrevious Guesses: {string.Join(',', guesses)}\n");
                Console.WriteLine("\t===================================");
                Console.WriteLine("\n\tWhat is you guess? ");
                Console.Write("\tNumber (between 1 and 10): ");
                isShort = short.TryParse(Console.ReadLine(), out guess);

                if (guess < 1) { Console.Clear(); }

            } while (!isShort || guess < 1);

            return guess;
        }

        private static void DisplayResult(short guess, short number) 
        {
            if (guess == number)
            {
                Console.WriteLine("\t===================================");
                Console.WriteLine("\n\t\t  YOU NAILED IT!!\n");
                Console.WriteLine("\t===================================");
            }
            else if (guess > number) Console.WriteLine("\tYour guess is greater than Number\n");
            else Console.WriteLine("\tYour guess is minor than Number\n");
        }
    }
}
