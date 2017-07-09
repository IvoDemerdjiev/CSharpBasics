using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrElements
{
    class Program
    {
        static void CompareElements(int[] arr, int position)
        {
            if (position == 0)
            {
                if (arr[position] > arr[position + 1])
                {
                    Console.WriteLine("The 0 element is bigger then the first");
                }
                else
                {
                    Console.WriteLine("The 1 element is bigger then the 0");
                }
                return;
            }
            if (position == arr.Length - 1)
            {
                if (arr[position] > arr[position - 1])
                {
                    Console.WriteLine("The last element is bigger than the element before the last ");
                }
                else
                {
                    Console.WriteLine("The element before the last is bigger than the last element ");
                }
                return;
            }
            if (arr[position - 1] < arr[position] && arr[position + 1] < arr[position])
            {
                Console.WriteLine("bigger than neibours ");
                return;
            }
            if (arr[position - 1] > arr[position] && arr[position + 1] > arr[position])
            {
                Console.WriteLine("smaller than neibours");
                return;
            }
            else
                Console.WriteLine("bigger than one and smaller by the other");
            return;
        }
        static void Main()
        {
            int[] arr = new int[] { 3, 4, 5, 7, 3, 5, 3 };
            Console.Write("Enter the possition of element:");
            int possition = int.Parse(Console.ReadLine());

            CompareElements(arr, possition);
        }
    }
}
