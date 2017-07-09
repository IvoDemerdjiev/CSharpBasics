using System;

class Speeds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //int n = 11;
        int sum = 0;
        int first = 0;
        int bestsum = 0;
        int len = 1;
        int bestlen = 0;
        //int[] array = { 4000, 4, 6, 5, 3, 3, 9, 100, 2, 3, 1 };
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

        }
        for (int i = 1; i < array.Length; i++)
        {

            if (array[i - 1] < array[i])
            {
                len++;
                if (first == 0)
                {
                    first = array[i - 1];
                    sum += first;
                }
                if (first != 0)
                {
                    sum += array[i];
                }
                if (bestlen==len && sum>bestsum)
                {
                    bestsum = sum;
                }
                if (bestlen<len)
                {
                    bestsum = sum;
                    bestlen = len;
                }
                array[i] = array[i - 1];
            }
            else
            {
                len = 1;
                first = 0;
                sum = 0;
            }
        }
        if (bestsum == 0)
        {
            Array.Sort(array);
            bestsum = array[n - 1];
        }
        Console.WriteLine(bestsum);
    }
}
