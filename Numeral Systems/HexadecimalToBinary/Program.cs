using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            string result = "";
            string[] starr = new string[hex.Length];
            hex = hex.ToUpper();
            for (int i = 0; i < hex.Length; i++)
            {
                starr[i] = hex.ToCharArray()[i].ToString();
            }
            for (int i = 0; i < starr.Length; i++)
            {
                switch (starr[i])
                {
                    case "0":
                        result += "0";
                        break;
                    case "1":
                        result += "1";
                        break;
                    case "2":
                        result += "10";
                        break;
                    case "3":
                        result += "11";
                        break;
                    case "4":
                        result += "100";
                        break;
                    case "5":
                        result += "101";
                        break;
                    case "6":
                        result += "110";
                        break;
                    case "7":
                        result += "111";
                        break;
                    case "8":
                        result += "1000";
                        break;
                    case "9":
                        result += "1001";
                        break;
                    case "A":
                        result += "1010";
                        break;
                    case "B":
                        result += "1011";
                        break;
                    case "C":
                        result += "1100";
                        break;
                    case "D":
                        result += "1101";
                        break;
                    case "E":
                        result += "1110";
                        break;
                    case "F":
                        result += "1111";
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}