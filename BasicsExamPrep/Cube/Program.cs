using System;


    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string str = " ";
            char pad = ' ';
            int k = n - 1;
            for (int i = n; i <= 2*n-1; i++)
            {
                if (i!=2*n-1)
                {
                    Console.Write(str.PadRight(k, pad));
                    k--;
                }
                for (int j = 1; j <= i; j++)
                {
                    bool empty = true;
                    if (i>n+1 && j>=n+1 && j!=i )
                    {
                        Console.Write("X");
                        empty = false;
                    }
                    if (i<2*n-1 && i!=n && (j>1 && j<n))
                    {
                        Console.Write("/");
                        empty = false;
                    }
                    if (empty==true)
                    {
                        Console.Write(":");
                    }
                   
                }
                Console.WriteLine();
            }
           for (int i = 2*n-2; i >= n ; i--)
            {
                for (int j = i; j >=1 ; j--)
                {
                   bool empty=true;
                    if (j<=i-n && j!=1 && i>=n+2)
                    {
                        Console.Write("X");
                        empty = false;
                    }
                    if (j<i && j>i-(n-1) && i>n)
                    {
                        Console.Write(" ");
                        empty=false;
                    }
                    else if (empty==true)
                    {
                        Console.Write(":");
               
                    }
                }
                Console.WriteLine();
            }
        }
    }
