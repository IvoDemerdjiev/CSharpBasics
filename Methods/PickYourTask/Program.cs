using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickYourTask
{
    class Program
    {
        static void FlipBackwords(int num)
        {
            int a = 0;
            while (num != 0)
            {
                a = num % 10;
                Console.Write(a);
                a = num / 10;
                num = a;
            }
            Console.WriteLine();
        }
        static void GetAvrige(int[] arr, int k)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Average:" + sum / k);
        }
        static void ЕquationSolution(double a, double b)
        {
            double x = 0;
            x = -(b / a);
            Console.WriteLine(x);
        }
        static void Main()
        {
            Console.WriteLine("Enter");
            Console.WriteLine("1:To flip the number backwords");
            Console.WriteLine("2:for average");
            Console.WriteLine("3:to solve a*x+b=0;");
            int num = int.Parse(Console.ReadLine());
            if (num != 1 && num != 2 && num != 3)
            {
                Console.WriteLine("You have entered a wrong number");
            }
            else
            {
                switch (num)
                {
                    case 1:
                        Console.Write("Enter number:");
                        int n = int.Parse(Console.ReadLine());
                        if (n >= -99 && n < 0)
                        {
                            Console.WriteLine("Wrong input");
                        }
                        else
                        {
                            FlipBackwords(n);
                        }
                        break;
                    case 2:
                        Console.Write("Enter the number of digit you what to enter:");
                        int k = int.Parse(Console.ReadLine());
                        int[] array = new int[k];
                        Console.WriteLine("Enter digits:");
                        for (int i = 0; i < k; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        GetAvrige(array, k);
                        break;
                    default:
                        Console.Write("Enter a:");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Enter b:");
                        int b = int.Parse(Console.ReadLine());
                        if (a != 0)
                        {
                            ЕquationSolution(a, b);
                        }
                        else
                        {
                            Console.WriteLine("a shound be diffrent from 0 ");
                        }
                        break;
                }
            }
        }
    }
}
