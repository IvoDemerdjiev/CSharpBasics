using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            long remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 9;
                decimalNumber /= 9;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
