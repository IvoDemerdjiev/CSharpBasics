using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SqrtX
    {
        static void Main(string[] args)
        {
            try
            {
                double num = double.Parse(Console.ReadLine());
                double x = Math.Sqrt(num);
                if (Double.IsNaN(0 / x)==true)
                {
                     Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("{0:F3}", x);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
