using System;

namespace MyNameSpace
{
    public class ExecuteLesson
    {
        private LessonHistory history;
        private LessonsContent lessonsContent;

        public ExecuteLesson()
        {
            history = new LessonHistory();
            lessonsContent = new LessonsContent();
        }

        public void LessonMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nLessons");
                Console.WriteLine("----------------------");
                Console.WriteLine("Select a lesson:");
                Console.WriteLine("1. Lesson 1 - Number Systems Introduction");
                Console.WriteLine("2. Lesson 2 - Binary Numbers");
                Console.WriteLine("3. Lesson 3 - Decimal Numbers");
                Console.WriteLine("4. Lesson 4 - Octal Numbers");
                Console.WriteLine("5. Lesson 5 - Hexadecimal Numbers");
                Console.WriteLine("6. Lesson 6 - Number System Conversions");
                Console.WriteLine("7. View Lesson History");
                Console.WriteLine("8. Back to Main Menu");
                Console.WriteLine("----------------------");
                Console.Write("Enter your choice (1-5): ");
                string lessonOption = Console.ReadLine();

                switch (lessonOption)
                {
                    case "1":
                        TakeLesson("Lesson 1 - Number Systems Introduction");
                        break;

                    case "2":
                        TakeLesson("Lesson 2 - Binary Numbers");
                        break;

                    case "3":
                        TakeLesson("Lesson 3 - Decimal Numbers");
                        break;
                    
                    case "4":
                        TakeLesson("Lesson 4 - Octal Numbers");
                        break;

                    case "5":
                        TakeLesson("Lesson 5 - Hexadecimal Numbers");
                        break;

                    case "6":
                        TakeLesson("Lesson 6 - Number System Conversions");
                        break;

                    case "7":
                        ViewLessonHistory();
                        break;

                    case "8":
                        Console.WriteLine("Going back to the main menu...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void TakeLesson(string lessonName)
        {
            Console.WriteLine($"Taking {lessonName}");
            Console.WriteLine("----------------------");

            string lessonContent = lessonsContent.GetLessonContent(lessonName);
            Console.WriteLine(lessonContent);
            Console.WriteLine("----------------------");

            history.AddLesson(lessonName);
        }

        private void ViewLessonHistory()
        {
            Console.WriteLine("\nLesson History");
            Console.WriteLine("----------------------");

            if (history.IsEmpty())
            {
                Console.WriteLine("No lesson history available.");
                Console.WriteLine("----------------------");
            }
            else
            {
                foreach (var entry in history.GetLessons())
                {
                    Console.WriteLine($"Lesson: {entry.LessonName}");
                    Console.WriteLine($"Date and Time: {entry.DateTime}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}
