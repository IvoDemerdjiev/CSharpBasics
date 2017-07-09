using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Split
    {
        static void Main(string[] args)
        {
            string s = "one\\two\\three";
            string[] words = s.Split('\\');
            foreach (string word in words)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }
    }
}
