using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long firstNumber = 0;
        long secondNumber = 1;
        long nextNumber = 1;
        if (n == 1)
        {
            Console.WriteLine(firstNumber);
        }
        if (n == 2)
        {
            Console.WriteLine(" {0}, {1}", firstNumber, secondNumber);
        }
        if (n == 3)
        {
            Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, nextNumber);
        }
        if (n > 3)
        {
            Console.Write("{0}, {1}, {2}", firstNumber, secondNumber, nextNumber);
            for (int i = 4; i <= n; i++)
            {
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                nextNumber = firstNumber + secondNumber;
                Console.Write(", " + nextNumber);
            }
            Console.WriteLine();
        }
    }
}