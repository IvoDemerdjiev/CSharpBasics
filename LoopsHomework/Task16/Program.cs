using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        public static void KnuthShuffle<T>(T[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int j = random.Next(i, array.Length); 
                T temp = array[i]; array[i] = array[j]; array[j] = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n :");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
            }
            KnuthShuffle(arr);
           Console.Write("The number after shuffle are: ");
            foreach (int value in arr)
            {
                Console.Write(" " + value);
            }
            Console.WriteLine();
        }
    }
}
