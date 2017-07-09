using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        internal static double Factoriel(double x)
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
            double N = double.Parse(Console.ReadLine());
            Console.Write("Enter K : ");
            double K = double.Parse(Console.ReadLine());
            double I = N - K;
            if (1 < K && K < N)
            {
                Console.WriteLine("FACT of N!*K!/(N-K)! = " + (Factoriel(N) * Factoriel(K)) / Factoriel(I));
            }
            else
            {
                Console.WriteLine("INVALID OUTPUT");
            }
        }
    }
}
