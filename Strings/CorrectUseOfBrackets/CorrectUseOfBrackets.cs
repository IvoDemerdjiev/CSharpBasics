using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectUseOfBrackets
{
    class CorrectUseOfBrackets
    {
        static void Main(string[] args)
        {
            string equation = "((a+b))";
            int openBracket = 0;
            int closeBracket = 0;
            for (int i = 0; i < equation.Length; i++)
            {
                int index = equation.IndexOf(")");
                int index2 = equation.IndexOf("(");
                if (index < index2)
                {
                    closeBracket = -1;
                    Console.WriteLine("Incorrect use of brackets");
                    break;
                }
                else
                {
                    if (equation[i].Equals("(")==true)
                    {
                        openBracket=openBracket+1;
                    }
                    if (equation[i].Equals(")")==true)
                    {
                        closeBracket++;
                    }
                }

            }
            if (closeBracket != -1)
            {
                if (openBracket == closeBracket)
                {
                    Console.WriteLine("Correct use of brackets");
                }
                else
                {
                    Console.WriteLine("Incorrect use of brackets");
                } 
            }
        }
    }
}
