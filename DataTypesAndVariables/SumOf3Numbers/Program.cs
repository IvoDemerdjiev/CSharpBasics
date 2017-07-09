using System;

class Trailing
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        int n = 4;
        int[,] array = new int[n,n];
        string direction = "right";
        int row = 0;
        int col = 0;
        for (int i = 1; i <= n*n; i++)
        {
            Console.WriteLine(array[row, col] = i);
            if (direction == "right" && col == n-1)
            {
                direction = "down";
            }
            if (direction == "down" && row == n-1)
            {
                direction = "left";
            }
            if (direction == "left" && col == 0)
            {
                direction = "up";
            }
            if (direction == "up" && row==n-2)
            {
                direction = "right";
            }
            if (direction=="right")
            {
                col++;
            }
            if (direction=="down")
            {
                row++;
            }
            if (direction=="left")
            {
                col--;
            }
            if (direction=="up")
            {
                row--;
            }
        }

    }
}