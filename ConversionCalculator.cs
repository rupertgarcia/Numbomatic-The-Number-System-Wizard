using System;

class ConversionCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversion Calculator");
        Console.WriteLine("----------------------");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Metric Conversion");
            Console.WriteLine("2. Temperature Conversion");
            Console.WriteLine("3. Number System Conversion");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("\nMetric Conversion");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Centimeter to Inch");
                    Console.WriteLine("2. Inch to Centimeter");

                    Console.Write("Enter your choice (1-2): ");
                    string metricOption = Console.ReadLine();

                    switch (metricOption)
                    {
                        case "1":
                            Console.Write("Enter the length in centimeters: ");
                            double centimeters = Convert.ToDouble(Console.ReadLine());
                            double inches = centimeters * 0.393701;
                            Console.WriteLine("Length in inches: " + inches);
                            break;
                        case "2":
                            Console.Write("Enter the length in inches: ");
                            double inchesInput = Convert.ToDouble(Console.ReadLine());
                            double centimetersResult = inchesInput * 2.54;
                            Console.WriteLine("Length in centimeters: " + centimetersResult);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\nTemperature Conversion");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Celsius to Fahrenheit");
                    Console.WriteLine("2. Fahrenheit to Celsius");

                    Console.Write("Enter your choice (1-2): ");
                    string temperatureOption = Console.ReadLine();

                    switch (temperatureOption)
                    {
                        case "1":
                            Console.Write("Enter the temperature in Celsius: ");
                            double celsius = Convert.ToDouble(Console.ReadLine());
                            double fahrenheit = (celsius * 9 / 5) + 32;
                            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
                            break;
                        case "2":
                            Console.Write("Enter the temperature in Fahrenheit: ");
                            double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
                            double celsiusResult = (fahrenheitInput - 32) * 5 / 9;
                            Console.WriteLine("Temperature in Celsius: " + celsiusResult);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;

                case "3":
                    Console.WriteLine("\nNumber System Conversion");
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Binary to Decimal");
                    Console.WriteLine("2. Decimal to Binary");

                    Console.Write("Enter your choice (1-2): ");
                    string numberOption = Console.ReadLine();

                    switch (numberOption)
                    {
                        case "1":
                            Console.Write("Enter the Binary Numbers: ");
                            int binaryNumber = int.Parse(Console.ReadLine());
                            int decimalValue = 0;
                            // initializing base1 value to 1, i.e 2^0 
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
