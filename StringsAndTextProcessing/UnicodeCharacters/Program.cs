using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetHexFromChar(input));
        }

        static string GetHexFromChar(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(String.Format(@"\u{0:X4}", (int)text[i]));
            }
            return sb.ToString();
        }
    }
}
