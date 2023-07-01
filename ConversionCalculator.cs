using System;
using MyNameSpace;

namespace MyNameSpace
{
    public class NumberSystembolab
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");        
            Console.WriteLine("Learning About Number Systems");
            Console.WriteLine("--------------------------------");

            while (true)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Lessons");
                Console.WriteLine("2. Number System Converter");
                Console.WriteLine("3. Have fun!");
                Console.WriteLine("4. Exit");
                Console.WriteLine("----------------------");
                Console.Write("Enter your choice (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

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
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}