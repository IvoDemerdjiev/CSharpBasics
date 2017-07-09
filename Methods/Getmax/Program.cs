using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getmax
{
    class Program
    {
        static void GetMax(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine(a);
            }
            if (b>a)
            {
                Console.WriteLine(b); 
            }
            if (a==b)
            {
                Console.WriteLine(a); 
            }
        }
        static void Main(string[] args)
        {
            GetMax(Math.Max(15, 7),15);
        }
    }
}
