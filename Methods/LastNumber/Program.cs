using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNumber
{
    class Program
    {
        static void LastNumber(int a)
        {
            int b = a % 10;
            switch (b)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                default:
                    Console.WriteLine("Nine");
                    break;
            }
        }
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            LastNumber(num);
        }
    }
}
