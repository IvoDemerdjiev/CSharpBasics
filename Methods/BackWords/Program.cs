using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackWords
{
    class Program
    {
        static void PrintBackwords(int c)
        {
            int a = c % 10;
            int b = c / 10;
            Console.WriteLine("{0}{1} " ,a,b);
        }
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if (num>10 && num<99)
            {
                PrintBackwords(num);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
