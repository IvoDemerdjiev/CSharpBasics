using System;

class MatrixOfNumbers
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        string[] tokens = line.Split(' ');
        long[] array = Array.ConvertAll(tokens, long.Parse);
        long odd = 1;
        long even = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                odd *= array[i];
            }
            if (i % 2 != 0)
            {
                even *= array[i];
            }
        }
        if (odd == even)
        {
            Console.WriteLine("yes {0}", odd);
        }
        if (odd != even)
        {
            Console.WriteLine("no {0} {1}", odd, even);
        }
    }
}