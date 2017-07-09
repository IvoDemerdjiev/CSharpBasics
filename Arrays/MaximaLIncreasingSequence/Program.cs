using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int len = 1;
        int bestlen = 1;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                len++;
                if (len > bestlen)
                {
                    bestlen = len;
                }
            }
            else
            {
                len = 1;
            }
        }
        Console.WriteLine(bestlen);
    }
}
