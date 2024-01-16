namespace DisplayMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = Menu();

            }

            Console.ReadLine();
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Insert an option: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Chassin Game");
            Console.WriteLine("3) Exit");
            string userOption = Console.ReadLine();

            if (userOption == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (userOption == "2")
            {
                GuessinGame();
                return true;
            }
            else if (userOption == "3")
            {
                return false;
            }
            else
                return true;
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Type a number");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (number + 1 > counter)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            ExitMenu();

        }

        private static void GuessinGame()
        {
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            bool incorrect = true;
            int guesses = 0;

            do {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                    Console.WriteLine("Wrong!");
            } while (incorrect);
            Console.WriteLine($"Correct! It took you {guesses} guesses.");
            ExitMenu();
        }
        private static void ExitMenu()
        {
            Console.WriteLine("\nPress any key to back to Menu: ");
            Console.ReadLine();
        }
    }
}