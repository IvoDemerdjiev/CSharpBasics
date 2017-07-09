namespace BaseNToDecimal
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Startup
    {
        static BigInteger BaseNToDecimal(string nValue, long radix, Dictionary<char, BigInteger> digitsToValues)
        {
            BigInteger sum = 0;

            foreach (char digit in nValue)
            {
                sum = digitsToValues[digit] + sum * radix;
            }

            return sum;
        }

        static void Main()
        {

            long radix = 26;
            long radix2 = 7;
            var digitsToValues = new Dictionary<char, BigInteger>();
            var digitsToValues2 = new Dictionary<char, BigInteger>();

            for (int i = 0; i < radix; i++)
            {
                char digit = (char)(97 + i);
                BigInteger value = i;

                digitsToValues.Add(digit, value);
            }
            for (int i = 0; i < radix2; i++)
            {
                char digit = (char)(i + '0');
                int value = i;

                digitsToValues2.Add(digit, value);
            }

            var numberToConvert = Console.ReadLine();
            string point = Console.ReadLine();
            var numberToConvert2 = Console.ReadLine();
            BigInteger numberToConvert3 = 0;
            BigInteger decimalValue = BaseNToDecimal(numberToConvert, radix, digitsToValues);
            BigInteger decimalValue2 = BaseNToDecimal(numberToConvert2, radix2, digitsToValues2);

            if (point == "+")
            {
                numberToConvert3 = decimalValue + decimalValue2;
            }
            else
            {
                numberToConvert3 = decimalValue - decimalValue2;
            }
            BigInteger remainder;
            string result = " ";
            while (numberToConvert3 > 0)
            {
                remainder = numberToConvert3 % 9;
                numberToConvert3 /= 9;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}