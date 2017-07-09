using System;



class Program
{
    static void Main(string[] args)
        {
            int n = 14;
            int[,] matrix = new int[10, 10];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row==0 && (col==n/2 || col==n/2-1))
                    {
                        Console.Write('#');
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
}
