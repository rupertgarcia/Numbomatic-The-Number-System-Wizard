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
        private ExecuteConversion conversion;
        private ExecuteRecreational recreation;
        private ExecuteLesson lesson;

        public NumberSystemMenu()
        {
            running = true;
            conversion = new ExecuteConversion();
            recreation = new ExecuteRecreational();
            lesson = new ExecuteLesson();
        }

        public void Start()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Numbomatic: The Number System Archon");
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
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Lessons");
            Console.WriteLine("2. Number System Converter");
            Console.WriteLine("3. Recreational (Have Fun!)");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------------");
            Console.Write("Enter your choice (1-4): ");
        }

        private void ProcessInput(string input)
        {
            switch (input)
            {
                case "1":
                    lesson.LessonMenu();
                    break;

                case "2":
                    conversion.ConvertNumberSystem();
                    break;

                case "3":
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
