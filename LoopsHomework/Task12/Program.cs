using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int quot;

        string rem = string.Empty;

        while (num >= 1)
        {
            quot = num / 2;
            rem += (num % 2).ToString();
            num = quot;
        }
        string bin = string.Empty;
        for (int i = rem.Length - 1; i >= 0; i--)
        {
            bin = bin + rem[i];

        }

        Console.WriteLine(bin);
    }
}
