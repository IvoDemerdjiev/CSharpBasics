using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static double Factoriel(double x)
        {
          double fact = 1;
          while (x!=1)
          {
              fact *= x;
              x--;
          }
          return fact;  
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n : ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Enter x : ");
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            double result=1;
            if (x>0 && n>0)
            {
                for (int i = 1; i < n; i++)
                {
                    result *= x;
                    sum += (Factoriel(i) / result);
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
