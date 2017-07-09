using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[] unsorted =new int[n];

            for (int i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = int.Parse(Console.ReadLine());
            }

            Quicksort(unsorted, 0, unsorted.Length - 1);

            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
        }

    }
}