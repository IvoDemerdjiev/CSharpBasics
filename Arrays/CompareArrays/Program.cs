using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[n];
        bool equal = true;
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i]==array2[i])
            {
                equal = true;
            }
            else
            {
                equal = false;
                break;
            }
        }
        if (equal==true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}
