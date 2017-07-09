using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        string equation = Console.ReadLine();
        int OpeningBracket = 0;
        int ClosingBracket = 0;
        for (int i = 0; i < equation.Length; i++)
        {
            if (equation[i]=='(')
            {
                OpeningBracket++;
            }
            if (equation[i]==')')
            {
                ClosingBracket++;
            }
            if (equation[i] == ')' && OpeningBracket == 0)
            {
                Console.WriteLine("Incorrect");
                break;
            }
            if (ClosingBracket>OpeningBracket)
            {
                Console.WriteLine("Incorrect");
                break;
            }
            if (i == equation.Length - 1 && OpeningBracket > ClosingBracket)
            {
                Console.WriteLine("Incorrect");
                break;
            }
        }
        if (OpeningBracket==ClosingBracket)
        {
            Console.WriteLine("Correct");
        }
    }
}