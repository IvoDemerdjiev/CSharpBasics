using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static double Factoriel(double x)
        {
            double fact = 1;
            while (x != 1)
            {
                fact *= x;
                x--;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            double fact = 0;
            double m = 5;
            double result=1;
            int x = 0;
            if (n>0)
            {
               fact=Factoriel(n);
               for (int i = 1; i < n; i++)
               {
                   result *= m;
                   if (fact % result == 0 )
                   {
                       x++;
                   }
               }
               Console.WriteLine(x);
            }
        }
    }
}
