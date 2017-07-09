using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        static void Main(string[] args)
        {
            int x = 1029;
            int y = 1071;
            Console.WriteLine("Gcd is : " + GCD(x,y));
        }
    }
}
