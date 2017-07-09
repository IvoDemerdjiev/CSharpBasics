using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeString
{
    class UnicodeString
    {
        static void Main(string[] args)
        {
            string str = "Наков";
            foreach (char s in str)
            {
                Console.Write("U+{0:x4} ", (int)s);
            }
            Console.WriteLine();
        }
    }
}
