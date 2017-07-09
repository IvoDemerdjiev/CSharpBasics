using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static double Factoriel(double x)
        {
            double fact = 1;
            while (x != 0)
            {
                fact *= x;
                x--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            double n = double.Parse(Console.ReadLine());
            double x = 2 * n;
            double y = n + 1;
            Console.WriteLine("The {0} number of Katalan is : " + (Factoriel(x) / (Factoriel(y) * Factoriel(n))), n);
        }
    }
}
