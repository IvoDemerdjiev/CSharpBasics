using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Console.WriteLine("sentence.Contains(\"jumped\") = {0}",
                sentence.Contains("jumpedfg"));
        }
    }
}
