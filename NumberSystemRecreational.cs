using System;
using System.Collections.Generic;

namespace MyNameSpace
{
    public class ExecuteRecreational
    {
        public void RecreationalGames()
        {
            Console.WriteLine("\nHave Some Fun!");
            Console.WriteLine("----------------------");

            List<int> numberHistory = new List<int>();
            List<int> guessHistory = new List<int>();

            while (true)
            {
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
                                Console.WriteLine("Congratulations, you guessed the number!");
                                Console.WriteLine("Number of guesses: " + numberOfGuesses);

                                numberHistory.Add(randomNumber);
                                guessHistory.Add(numberOfGuesses);
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nNumber History and Guesses");
                        Console.WriteLine("----------------------");

                        if (numberHistory.Count == 0)
                        {
                            Console.WriteLine("No previous numbers and guesses.");
                            Console.WriteLine("----------------------");
                        }
                        else
                        {
                            for (int i = 0; i < numberHistory.Count; i++)
                            {
                                Console.WriteLine($"Number: {numberHistory[i]}, Guesses: {guessHistory[i]}");
                            }
                        }
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
    }
}