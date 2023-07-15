using System;

namespace MyNameSpace
{
    public class ExecuteConversion
    {
        private ConversionHistory history;

        public ExecuteConversion()
        {
            history = new ConversionHistory();
        }

        public void ConvertNumberSystem()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nNumber System Conversion");
                Console.WriteLine("----------------------");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Binary to Decimal");
                Console.WriteLine("2. Decimal to Binary");
                Console.WriteLine("3. View Conversion History");
                Console.WriteLine("4. Back to Main Menu");
                Console.WriteLine("----------------------");
                Console.Write("Enter your choice (1-4): ");
                string numberSystemOption = Console.ReadLine();

                switch (numberSystemOption)
                {
                    case "1":
                        Console.Write("Enter the Binary Number: ");
                        int binaryNumber = int.Parse(Console.ReadLine());
                        int decimalValue = BinaryToDecimal(binaryNumber);
                        Console.WriteLine($"Decimal Value: {decimalValue}");
                        history.AddConversion(binaryNumber, decimalValue);
                        break;

                    case "2":
                        Console.Write("Enter the Decimal Number: ");
                        int decimalNumber = int.Parse(Console.ReadLine());
                        int[] binaryArray = DecimalToBinary(decimalNumber);
                        Console.WriteLine("Binary Representation: ");
                        foreach (int bit in binaryArray)
                        {
                            Console.Write(bit);
                        }
                        Console.WriteLine();
                        history.AddConversion(decimalNumber, BinaryArrayToDecimal(binaryArray));
                        break;

                    case "3":
                        ViewConversionHistory();
                        break;

                    case "4":
                        Console.WriteLine("Going back to the main menu...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private int BinaryToDecimal(int binaryNumber)
        {
            int decimalValue = 0;
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int remainder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += remainder * base1;
                base1 = base1 * 2;
            }

            return decimalValue;
        }

        private int[] DecimalToBinary(int decimalNumber)
        {
            int[] binaryArray = new int[32];
            int index = 0;

            if (decimalNumber == 0)
            {
                binaryArray[index++] = 0;
            }
            else
            {
                while (decimalNumber > 0)
                {
                    binaryArray[index++] = decimalNumber % 2;
                    decimalNumber = decimalNumber / 2;
                }
            }

            int[] result = new int[index];
            Array.Copy(binaryArray, result, index);

            Array.Reverse(result); // Reverse the array to get correct binary representation

            return result;
        }

        private int BinaryArrayToDecimal(int[] binaryArray)
        {
            int decimalValue = 0;
            int base1 = 1;

            for (int i = binaryArray.Length - 1; i >= 0; i--)
            {
                decimalValue += binaryArray[i] * base1;
                base1 = base1 * 2;
            }

            return decimalValue;
        }

        private void ViewConversionHistory()
        {
            Console.WriteLine("\nConversion History");
            Console.WriteLine("----------------------");

            if (history.IsEmpty())
            {
                Console.WriteLine("No conversion history available.");
                Console.WriteLine("----------------------");
            }
            else
            {
                foreach (var entry in history.GetConversions())
                {
                    Console.WriteLine($"Original Value: {entry.OriginalValue}");

                    if (entry.OriginalValue != entry.ConvertedValue)
                    {
                        Console.WriteLine($"Converted Value: {entry.ConvertedValue}");
                    }
                    else
                    {
                        int[] binaryArray = DecimalToBinary(entry.ConvertedValue);
                        Console.Write("Binary Representation: ");
                        foreach (int bit in binaryArray)
                        {
                            Console.Write(bit);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine($"Date and Time: {entry.DateTime}");
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}
