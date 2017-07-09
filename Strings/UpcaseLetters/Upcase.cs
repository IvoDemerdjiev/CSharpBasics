using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcaseLetters
{
    class Upcase
    {
        static void Main()
        {
            string message = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int index = message.IndexOf("<upcase>");
            int index2 = message.IndexOf("We are");
            int index3 = message.IndexOf("<upcase>");
            int index4 = message.IndexOf(". We");
            int index5 = message.IndexOf(" else.");
            string part2 = message.Substring(index+8,16);
            string part4 = message.Substring(index3 + 8, 8);
            string part1 = message.Substring(index2, 19);
            string part3 = message.Substring(index4, 16);
            string part5 = message.Substring(index5);
            Console.WriteLine(part1 + part2.ToUpper() + part3 + part4.ToUpper() + part5);
        }
    }
}
