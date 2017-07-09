using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int max = -2147483648;
            int min = 2147483647;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (min>num)
                {
                    min = num;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
