using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLenght
{
    static void Main()
    {
        string Sentence = Console.ReadLine();
        Sentence = Sentence.Replace(@"\", string.Empty);
        if (Sentence.Length < 20)
        {
            Console.WriteLine(Sentence.PadRight(20, '*'));
        }
        else
        {
            Console.WriteLine(Sentence);
        }
    }
}
