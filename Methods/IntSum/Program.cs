using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSum
{
    class Program
    {
        static void GetSum(int[] arr, int[] arr2,int n,int m)
        {
            int[] arr3;
            if (m<n)
            {
                arr3 = arr;
                arr = arr2;
                arr2 = arr3;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    int a = (arr[i] + arr2[i]) % 10;
                    Console.Write(a);
                }
                if (i == 1)
                {
                    int b = (arr[i] + arr2[i]) % 10 + (arr[i - 1] + arr[i - 1]) / 10;
                    Console.Write(b);
                }
                if (i == 2)
                {
                    int c = (arr[i] + arr2[i]) % 10 + (arr[i - 1] + arr[i - 1]) / 10;
                    Console.Write(c);
                }
                if (i == 3)
                {
                    int d = (arr[i] + arr2[i]) % 10 + (arr[i - 1] + arr[i - 1]) / 10;
                    Console.Write(d);
                }
                if (i == 4)
                {
                    int e = (arr[i] + arr2[i]) % 10 + (arr[i - 1] + arr[i - 1]) / 10;
                    Console.Write(e);
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter the number of elements of the arrays : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("Enter the number of elements of the arrays : ");
            int m = int.Parse(Console.ReadLine());
            int[] array2 = new int[m];
            if (n > 0 & n < 5)
            {
                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    if (array[i]<0 || array[i]>9)
                    {
                        Console.WriteLine("wrong input only the last digit of the number will be used");
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    array2[i] = int.Parse(Console.ReadLine());
                    if (array2[i] < 0 || array2[i] > 9)
                    {
                        Console.WriteLine("wrong input only the last digit of the number will be used");
                    }
                }
                GetSum(array, array2,n,m);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Incoreced Input");
            }
        }
    }
}
