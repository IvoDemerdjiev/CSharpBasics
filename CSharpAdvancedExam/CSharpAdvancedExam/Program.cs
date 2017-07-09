using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CSharpAdvancedExam
{
    class Program
    {
        static long TwentySix(string number)
        {
            long result = 0;
            long count = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                long temp = 0;
                switch (number[i])
                {
                    case 'a': temp = 0; break;
                    case 'b': temp = 1; break;
                    case 'c': temp = 2; break;
                    case 'd': temp = 3; break;
                    case 'e': temp = 4; break;
                    case 'f': temp = 5; break;
                    case 'g': temp = 6; break;
                    case 'h': temp = 7; break;
                    case 'i': temp = 8; break;
                    case 'j': temp = 9; break;
                    case 'k': temp = 10; break;
                    case 'l': temp = 11; break;
                    case 'm': temp = 12; break;
                    case 'n': temp = 13; break;
                    case 'o': temp = 14; break;
                    case 'p': temp = 15; break;
                    case 'q': temp = 16; break;
                    case 'r': temp = 17; break;
                    case 's': temp = 18; break;
                    case 't': temp = 19; break;
                    case 'u': temp = 20; break;
                    case 'v': temp = 21; break;
                    case 'w': temp = 22; break;
                    case 'x': temp = 23; break;
                    case 'y': temp = 24; break;
                    case 'z': temp = 25; break;
                    default: temp = -48 + (int)number[i]; break;

                }
                result += temp * (long)(Math.Pow(26, count));
                //sum = digitsToValues[digit] + sum * radix;
                count--;
            }
            return result;
        }

        static long Seven(string number)
        {
            long result = 0;
            long count = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                long temp = 0;
                switch (number[i])
                {
                    case '0': temp = 0; break;
                    case '1': temp = 1; break;
                    case '2': temp = 2; break;
                    case '3': temp = 3; break;
                    case '4': temp = 4; break;
                    case '5': temp = 5; break;
                    case '6': temp = 6; break;

                    default: temp = -48 + (int)number[i]; break;

                }
                result += temp * (long)(Math.Pow(7, count));
                count--;
            }
            return result;
        }
        static void Main()
        {
            string TwentySixBasedNumber=Console.ReadLine();
            string operation = Console.ReadLine();
            string SevenBasedNumber = Console.ReadLine();
            long num1 = TwentySix(TwentySixBasedNumber);
            long num2 = Seven(SevenBasedNumber);
            long decimalNumber = 0;
            if (operation == "-")
            {
                decimalNumber = num1 - num2;
            }
            else
            {
                decimalNumber = num1 + num2;
            }
            long remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 9;
                decimalNumber /= 9;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
   
