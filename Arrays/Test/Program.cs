using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int max = 0;
        int maxNumber = int.MinValue;
        int biggestNumber = int.MaxValue;
        int index = 0;
        int bestIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= k; i++)
        {
            if (i > 1)
            {
                for (int m = 0; m < array.Length; m++)
                {
                    max = array[m];
                    index = m;
                    if (maxNumber == max && bestIndex != index && i<=k)
                    {
                        sum += max;
                        i++;
                    }
                }
                maxNumber = 0;
            }
            for (int j = 0; j < array.Length; j++)
            {
                
                max = array[j];
                index = j;
                if (max > maxNumber && i == 1)
                {
                    maxNumber = max;
                    bestIndex = index;
                }
                if (i > 1 && max > maxNumber && biggestNumber>max)
                {
                    maxNumber = max;
                    bestIndex = index;
                }
                if (j == n - 1 && i <= k)
                {
                    sum += maxNumber;
                    biggestNumber = maxNumber;
                }
            }
        }
        Console.WriteLine(sum);
    }
}
