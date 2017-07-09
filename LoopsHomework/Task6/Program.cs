using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter K : ");
            double num1 = double.Parse(Console.ReadLine());
            double k=1;
            double n=1;
            if (1<num1 && num1<num2)
            {
                while (num1!=0)
                {
                    k *=num1;
                    num1--;
                }
                while (num2!=0)
                {
                    n *= num2;
                    num2--;
                }
                Console.WriteLine("The devidion is = "+n/k);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
