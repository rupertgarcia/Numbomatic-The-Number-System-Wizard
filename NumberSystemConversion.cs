using System;

namespace MyNameSpace
{
    public class ExecuteConversion
    {
        public void ConvertNumberSystem()
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
    }
}