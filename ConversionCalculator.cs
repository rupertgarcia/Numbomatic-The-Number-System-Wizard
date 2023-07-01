using System;

namespace MyNameSpace
{
    public class NumberSystemProgram
    {
        public static void Main(string[] args)
        {
            NumberSystemMenu menu = new NumberSystemMenu();
            menu.Start();
        }
    }

    public class NumberSystemMenu
    {
        private bool running;

        public void Start()
        {
            running = true;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Learning About Number Systems");
            Console.WriteLine("--------------------------------");

            while (running)
            {
                DisplayMenu();
                string input = Console.ReadLine();
                ProcessInput(input);
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Lessons");
            Console.WriteLine("2. Number System Converter");
            Console.WriteLine("3. Have fun!");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------------");
            Console.Write("Enter your choice (1-4): ");
        }

        private void ProcessInput(string input)
        {
            switch (input)
            {
                case "1":
                    // Handle lessons
                    break;

                case "2":
                    ExecuteConversion conversion = new ExecuteConversion();
                    conversion.ConvertNumberSystem();
                    break;

                case "3":
                    ExecuteRecreational recreation = new ExecuteRecreational();
                    recreation.RecreationalGames();
                    break;

                case "4":
                    Console.WriteLine("Exiting the program...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}