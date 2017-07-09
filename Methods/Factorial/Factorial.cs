using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
       static void GetFactorial(int n)
        {
            BigInteger Fact = 1;
            while (n>0)
            {
                Fact = Fact * n;
                n--;
            }
            Console.WriteLine(Fact);
        }
        static void Main()
        {
            Console.Write("Enter number:");
            int n = int.Parse(Console.ReadLine());
            GetFactorial(n);
        }
    }
}
