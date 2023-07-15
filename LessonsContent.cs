namespace MyNameSpace
{
    public class LessonsContent
    {
        public string GetLessonContent(string lessonName)
        {
            switch (lessonName)
            {
                case "Lesson 1 - Number Systems Introduction":
                    return @"Lesson 1 - Number Systems Introduction
In this lesson, you will learn about different number systems and their importance in computer science and mathematics. We will cover the following topics:
- What are number systems?
- Binary, decimal, octal, and hexadecimal number systems
- Conversion between number systems
- Place value in number systems";

                case "Lesson 2 - Binary Numbers":
                    return @"Lesson 2 - Binary Numbers
In this lesson, we will focus on binary numbers, which form the basis of digital systems. You will learn:
- Binary number representation
- Converting binary to decimal and vice versa
- Addition and subtraction in binary
- Binary arithmetic operations";

                case "Lesson 3 - Decimal Numbers":
                    return @"Lesson 3 - Decimal Numbers
In this lesson, we will delve into the decimal number system, which is widely used in everyday life. You will explore:
- Understanding the decimal system
- Decimal place value and digits
- Addition, subtraction, multiplication, and division in decimal
- Rounding and precision in decimal numbers";

                case "Lesson 4 - Octal Numbers":
                    return @"Lesson 4 - Octal Numbers
In this lesson, we will study the octal number system, commonly used in computer programming. You will learn:
- Octal number representation
- Converting octal to decimal and binary
- Octal arithmetic operations
- Practical applications of octal numbers";

                case "Lesson 5 - Hexadecimal Numbers":
                    return @"Lesson 5 - Hexadecimal Numbers
In this lesson, we will explore the hexadecimal number system, frequently used in computer science and programming. You will discover:
- Hexadecimal number representation
- Converting hexadecimal to decimal and binary
- Hexadecimal arithmetic operations
- Hexadecimal color codes and memory addressing";

                case "Lesson 6 - Number System Conversions":
                    return @"Lesson 6 - Number System Conversions
In this lesson, we will dive deeper into number system conversions, allowing you to convert numbers between different bases. You will gain insights into:
- Converting binary, decimal, octal, and hexadecimal numbers
- Algorithms and methods for conversions
- Practical examples and exercises";

                default:
                    return "Lesson content not found.";
            }
        }
    }
}
