using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        long x = long.Parse(Console.ReadLine());
        string result = string.Empty;
        while (x != 0)
        {
            if ((x % 16) < 10)
                result = x % 16 + result;
            else
            {
                string temp = string.Empty;

                switch (x % 16)
                {
                    case 10: temp = "A"; break;
                    case 11: temp = "B"; break;
                    case 12: temp = "C"; break;
                    case 13: temp = "D"; break;
                    case 14: temp = "E"; break;
                    case 15: temp = "F"; break;
                }

                result = temp + result;
            }

            x /= 16;
        }
        Console.WriteLine(result);
    }
}
