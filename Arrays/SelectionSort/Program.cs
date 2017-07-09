using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int exchangeNumber = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] < array[j - 1])
                {
                    exchangeNumber = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = exchangeNumber;
                } 
            }
        }
        foreach (var element in array)
        {
            Console.WriteLine(element);
        }
    }
}
