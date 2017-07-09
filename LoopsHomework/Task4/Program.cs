using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    string Rank = (j).ToString();
                    switch (j)
                    {
                        case 0:
                            Rank="ACE";
                            break;
                        case 11:
                            Rank="Jack";
                            break;
                        case 12:
                           Rank="Queen";
                            break;
                        case 13 :
                            Rank="King";
                            break;
                    }
                    string suit = (i).ToString();
                    switch (i)
	                {
                    case 0:
                            suit = "Spades ";
                            break;
                        case 1:
                            suit = "Hearts  ";
                            break;
                        case 2:
                            suit = "Diamont";
                            break;
		          case 3:
                            suit = "Clubs";
                     break;
	                }
                    Console.WriteLine("{0} of {1}", Rank, suit);
                }
            }
        }
    }
}
