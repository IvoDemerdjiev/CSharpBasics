using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int transCount = 0;
        while (input.Length > 1 && transCount < 10)
        {
            BigInteger product = 1;
            while (input.Length > 1)
            {
                input = input.Substring(0, input.Length - 1);
                long sum = 0;
                for (int i = 0; i < input.Length; i += 2)
                {
                    sum += (long)(input[i] - '0');
                }
                product *= sum;
            }
            transCount++;
            input = product.ToString();
        }
        if (transCount < 10)
        {
            Console.WriteLine(transCount);
        }
        Console.WriteLine(input);
    }
}
