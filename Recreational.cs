using System;

namespace MyNameSpace
{
    public class ExecuteRecreational
    {
        private static RecreationalHistory history;

        public ExecuteRecreational()
        {
            if (history == null)
            {
                history = new RecreationalHistory();
            }
        }

        public void RecreationalGames()
        {
            Console.WriteLine("\nHave Some Fun!");

            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Guess a Random Number");
                Console.WriteLine("2. Show Number History and Guesses");
                Console.WriteLine("3. Exit");
                Console.WriteLine("----------------------");
                Console.Write("Enter your choice (1-3): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PlayGuessingGame();
                        break;

                    case "2":
                        ShowNumberHistory();
                        break;

                    case "3":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void PlayGuessingGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Guess a number between 1 and 100:");
            int guess = 0;
            int numberOfGuesses = 0;

            while (guess != randomNumber)
            {
                string guessInput = Console.ReadLine();
                if (!int.TryParse(guessInput, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                numberOfGuesses++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low. Guess again:");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high. Guess again:");
                }
                else
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Congratulations, you guessed the number!");
                    Console.WriteLine("Number of guesses: " + numberOfGuesses);
                    Console.WriteLine("----------------------");

                    history.AddNumberGuess(randomNumber, numberOfGuesses);
                }
            }
        }

        private void ShowNumberHistory()
        {
            Console.WriteLine("\nNumber History and Guesses");

            if (history.IsEmpty())
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("No previous numbers and guesses.");
                Console.WriteLine("----------------------");
            }
            else
            {
                foreach (var entry in history.GetNumberGuesses())
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine($"Number: {entry.Number}, Guesses: {entry.Guesses}, Date and Time: {entry.DateTime}");
                    Console.WriteLine("--------------------------------------------");
                }
            }
        }
    }
}
