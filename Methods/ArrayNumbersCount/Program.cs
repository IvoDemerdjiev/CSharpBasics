using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumbersCount
{
    class Program
    {
        static int ArrayNumbersCount(int[] arr,int num)
        {
            int len=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    len++;
                }
            }
            return len;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] {3,4,5,7,3,5,3};
            Console.Write("Number to search for: ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} repeats {1} times",num, ArrayNumbersCount(arr, num));
        }
    }
}
