using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 1;
            int z = x + y;
            int sum = 2;
            if (n > 0)
            {
                for (int i = 3; i < n; i++)
                {
                    x = y;
                    y = z;
                    z = x + y;
                    sum += z;
                }
                Console.WriteLine("The sum of the first n fibonaci numbers is = "+sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
