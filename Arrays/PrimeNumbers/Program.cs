using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] array = new bool[n+1];
        int biggestPrimeNumber = 0;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = true;
        }
        for (int i = 2; i <= n; i++)
        {
            if (array[i])
            {
                for (long j = i*2; j <= n; j+=i)
                {
                    array[j] = false;
                }
            }
        }
        for (int i = array.Length-1; i >=2; i--)
        {
            if (array[i]==true)
            {
                biggestPrimeNumber = i;
                break;
            }
        }
        Console.WriteLine(biggestPrimeNumber);
    }
}