using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thebiggestelement
{
    class Program
    {
        static void GettingTheNewPart(int[] arr,int start,int stop)
        {
            Array.Sort(arr);
            for (int i = start; i <= stop; i++)
            {
                if (i==stop)
                {
                    Console.WriteLine(arr[stop]);
                }
            }
        }
        static void Main()
        {
            int[] numbers = new int[] { 1, 5, 2, 1, 6, 3, 4, 2, 8, 3 };
            Console.Write("Enter from with element of the array to start searching: ");
            int start = int.Parse(Console.ReadLine());
            if (start>numbers.Length && start<0)
            {
                Console.WriteLine("Wrong input");
            }
            Console.Write("Enter from with element of the array to stop searching: ");
            int stop = int.Parse(Console.ReadLine());
            if (stop<start && stop>numbers.Length)
            {
                Console.WriteLine("Wrong input");
            }
            GettingTheNewPart(numbers, start, stop);
        }
    }
}
