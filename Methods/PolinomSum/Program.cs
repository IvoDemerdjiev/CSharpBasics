using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomSum
{
    class Program
    {
        static void PrintPolynom(int[] pol)
        {
            for (int i = pol.Length-1; i > 0; i--)
            {
                if (pol[i] != 0)
                    Console.Write("{0}x^{1}+", pol[i], i);
            }
            Console.WriteLine(pol[0]);
        }
        static void AddPolynom(string first, string second)
        {
            int len;
            int index;
            string temp = string.Empty;
            if (first.Length >= second.Length)
            {
                len = first.Length;
                index = second.Length;
                temp = first;
            }
            else
            {
                len = second.Length;
                index = first.Length;
                temp = second;
            }
            int[] result = new int[len];
            for (int i = 0; i < index; i++)
            {
                result[i] = (first[i]-'0') + (second[i]-'0');
            }
            for (int j = index; j < result.Length; j++)
            {
                result[j] = (temp[j]);
            }
            PrintPolynom(result);
        }
        static void Main(string[] args)
        {
            string firstPol = "3245";
            string secondPol = "3452";
            AddPolynom(firstPol, secondPol);
        }
    }
}
