using System;


class MutantSquirrels
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int sum=0;
        int bigSum = 0;
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i%j==0)
                {
                    sum = i / j;
                    if (sum%2==0)
                    {
                        bigSum += sum;
                    }
                }

            }
        }
        Console.WriteLine(bigSum);
    }
}
