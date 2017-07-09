using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string x = Console.ReadLine();
        long dec = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (x[x.Length - i - 1] == '0') continue;
            dec += (long)Math.Pow(2, i);
        }
        Console.WriteLine(dec);
    }
}
