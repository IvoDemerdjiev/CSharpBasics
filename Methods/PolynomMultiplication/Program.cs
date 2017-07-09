using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomMultiplication
{
    class Program
    {
        static void PrintPolynom(int[] pol)
        {
            for (int i = pol.Length - 1; i > 0; i--)
            {
                if (pol[i] != 0)
                    Console.Write("{0}x^{1}+", pol[i], i);
            }
            Console.WriteLine(pol[0]);
        }
        static void PolyMult(string first, string second)
        {
            int[] mult = new int[(first.Length) * (second.Length) + 1];
            int pow = 0;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    pow = i + j;
                    mult[pow]+=(first[i]-'0')*(second[j]-'0');
                }
            }
            PrintPolynom(mult);
        }
        static void Main(string[] args)
        {
            string first = "4534";
            string second = "5432";
            PolyMult(first, second);
        }
    }
}
