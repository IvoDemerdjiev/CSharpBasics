using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class BackWords
    {
        static void Main(string[] args)
        {
            string message = "introduction";
            for (int i = message.Length-1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            Console.WriteLine();
        }
    }
}
