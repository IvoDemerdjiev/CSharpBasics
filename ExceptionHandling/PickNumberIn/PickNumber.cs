using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickNumberIn
{
    class PickNumber
    {
        static bool goingUp = true;
        static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
                if ((number < start) || (number > end))
                {
                    goingUp = false;
                }
            }
            catch (OutOfMemoryException)
            {
                goingUp = false;
            }
            catch (ArgumentOutOfRangeException)
            {
                goingUp = false;
            }
            catch (ArgumentNullException)
            {
                goingUp = false;
            }
            catch (FormatException)
            {
                goingUp = false;
            }
            catch (OverflowException)
            {
                goingUp = false;
            }
            catch (Exception)
            {
                 goingUp = false;
            }

            return number;

        }
        static void Main()
        {
            int start = 1;
            int end = 100;
            byte count = 0;
            int previousNumber = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(1 + " < ");
            while (count < 10)
            {
                try
                {
                    int nexNumber = ReadNumber(start, end);
                    if (previousNumber >= nexNumber)
                    {
                        goingUp = false;
                    }
                    count++;
                    sb.Append(nexNumber + " < ");
                    previousNumber = nexNumber;
                }
                catch (ArgumentOutOfRangeException)
                {
                    goingUp = false;
                }
            }
            sb.Append(100);
            sb.ToString();
            if (goingUp==true)
            {
                Console.WriteLine(sb);
            }
            else if(goingUp==false)
            {
                Console.WriteLine("Exception");
            }
            
        }
    }
}
