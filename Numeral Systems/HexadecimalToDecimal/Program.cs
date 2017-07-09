using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine().ToUpper();
            long result = 0;
            long count = x.Length - 1;
            for (int i = 0; i < x.Length; i++)
            {
                long temp = 0;
                switch (x[i])
                {
                    case 'a': temp = 0; break;
                    case 'b': temp = 1; break;
                    case 'c': temp = 2; break;
                    case 'd': temp = 3; break;
                    case 'e': temp = 4; break;
                    case 'f': temp = 5; break;
                    case 'g': temp = 6; break;
                    case 'h': temp = 7; break;
                    case 'i': temp = 8; break;
                    case 'j': temp = 9; break;
                    case 'k': temp = 10; break;
                    case 'l': temp = 11; break;
                    case 'm': temp = 12; break;
                    case 'n': temp = 13; break;
                    case 'o': temp = 14; break;
                    case 'p': temp = 15; break;
                    case 'q': temp = 16; break;
                    case 'r': temp = 17; break;
                    case 's': temp = 18; break;
                    case 't': temp = 19; break;
                    case 'u': temp = 20; break;
                    case 'v': temp = 21; break;
                    case 'w': temp = 22; break;
                    case 'x': temp = 23; break;
                    case 'y': temp = 24; break;
                    case 'z': temp = 25; break;
                    default: temp = -48 + (int)x[i]; break;
                }

                result += temp * (long)(Math.Pow(16, count));
                count--;
            }
            Console.WriteLine(result);
        }
    }
}
