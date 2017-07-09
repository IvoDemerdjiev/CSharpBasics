using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int bestSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            if (sum>bestSum)
            {
                bestSum = sum;
            }
            if (sum<0)
            {
                sum = 0;
            }
        }
        Console.WriteLine(bestSum);
    }
}
