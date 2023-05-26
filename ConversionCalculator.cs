using System;
using System.Collections.Generic;

class ConversionCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------------");        
        Console.WriteLine("Data Analyzer");
        Console.WriteLine("----------------------");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Number System Conversion");
            Console.WriteLine("2. List of Numbers Sorter");
            Console.WriteLine("3. Random Number Game");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------------");
            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    ExecuteNumberSystemConversion();
                    break;

                case "2":
                    ExecuteNumberSorter();
                    break;

                case "3":
                    ExecuteRandomNumber();
                    break;

                case "4":
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ExecuteNumberSystemConversion()
    {
        Console.WriteLine("\nNumber System Conversion");
        Console.WriteLine("----------------------");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Binary to Decimal");
        Console.WriteLine("2. Decimal to Binary");
        Console.WriteLine("----------------------");
        Console.Write("Enter your choice (1-2): ");
        string numberSystemOption = Console.ReadLine();

        switch (numberSystemOption)
        {
            case "1":
                Console.Write("Enter the Binary Numbers: ");
                int binaryNumber = int.Parse(Console.ReadLine());
                int decimalValue = 0;
                int base1 = 1;
                        
                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10;
                    binaryNumber = binaryNumber / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.WriteLine($"Decimal Value : {decimalValue} ");
                break;

            case "2":
                Console.Write("Enter the Decimal Numbers: ");
                int number = int.Parse(Console.ReadLine());
                int i;
                int[] numberArray = new int[10];
                for (i = 0; number > 0; i++)
                {
                    numberArray[i] = number % 2;
                    number = number / 2;
                }
                Console.WriteLine("Binary Representation of the given Number : ");
                for (i = i - 1; i >= 0; i--)
                {
                    Console.Write(numberArray[i]);
                }
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }        
    }

    static void ExecuteNumberSorter()
    {
        Console.WriteLine("\nNumber Sorter");
        Console.WriteLine("----------------------");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("(Wait for updates)");
        Console.WriteLine("----------------------");
        Console.Write("Enter your choice (1-2): ");
        string numberSortOption = Console.ReadLine();

        switch (numberSortOption)
        {
            case "1":
                Console.Write("Enter a series of numbers (separated by spaces): ");
                string input = Console.ReadLine();
                string[] numbersArray = input.Split(' ');

                List<int> numbersList = new List<int>();
                foreach (string numberStr in numbersArray)
                {
                    if (int.TryParse(numberStr, out int number))
                    {
                        numbersList.Add(number);
                    }
                }

                int sortCount = 0;
                for (int i = 0; i < numbersList.Count - 1; i++)
                {
                    for (int j = 0; j < numbersList.Count - 1 - i; j++)
                    {
                        if (numbersList[j] > numbersList[j + 1])
                        {
                            int temp = numbersList[j];
                            numbersList[j] = numbersList[j + 1];
                            numbersList[j + 1] = temp;
                            sortCount++;
                        }
                    }
                }

                Console.WriteLine("Sorted List: " + string.Join(", ", numbersList));
                Console.WriteLine("Number of Sorts: " + sortCount);                
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void ExecuteRandomNumber()
    {
        Console.WriteLine("\nRandom Number Game");
        Console.WriteLine("----------------------");

        List<int> numberHistory = new List<int>();
        List<int> guessHistory = new List<int>();

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
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
