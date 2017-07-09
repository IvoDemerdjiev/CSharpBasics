using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N in 1..20 : ");
            int n = int.Parse(Console.ReadLine());
            if (n>0 && n<20)
            {
                for (int i = 1; i <=n; i++)
                {
                    for (int j = i; j <=n-1+i ; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
