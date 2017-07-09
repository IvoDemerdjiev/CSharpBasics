using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int target = int.Parse(Console.ReadLine());
        int mid = 0, first = 0, last = array.Length - 1;

        bool found = false;

        while (!found && first <= last)
        {
            mid = (first + last) / 2;

            if (target == array[mid])
            {
                index = mid;
                found = true;
            }
            else
            {

                if (target > array[mid])
                {
                    first = mid + 1;
                }

                if (target < array[mid])
                {
                    last = mid - 1;
                }
            }
        }
        if (found==false)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(index);
        }
    }
}
