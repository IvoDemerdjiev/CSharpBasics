using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SeriesOfLetters(input);
        }

        static void SeriesOfLetters(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i-1]!=text[i])
                {
                    sb.Append(text[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
