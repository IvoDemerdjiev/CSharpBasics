using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();
            bool[] boolarray = new bool[input.Length];
            bool[] boolarray2 = new bool[input.Length];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
            }
            string input2 = Console.ReadLine().Trim();
            int[] array = input2.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int coderSouls = 0;
            int foodCollected = 0;
            int deadlocks = 0;
            int position = 0;
            int numberOfjumps = 0;
            bool alive = true;
            int moves = array.Length;
            int p = 0;
            while (moves >= 0)
            {
                if (sb[position] == '@')
                {
                    if (boolarray[position] == false)
                    {
                        coderSouls++;
                    }
                    boolarray[position] = true;

                }
                if (sb[position] == '*')
                {
                    if (boolarray2[position] == false)
                    {
                        foodCollected++;
                    }
                    boolarray2[position] = true;
                }
                if (sb[position] == 'x' && position % 2 == 0)
                {
                    if (coderSouls <= 0)
                    {
                        alive = false;
                        break;
                    }
                    coderSouls--;
                    deadlocks++;
                }
                if (sb[position] == 'x' && position % 2 != 0)
                {
                    if (foodCollected <= 0)
                    {
                        alive = false;
                        break;
                    }
                    foodCollected--;
                    deadlocks++;
                }
                if (moves > 0)
                {
                    position += array[p];
                    p++;
                    while (position<0)
                    {
                        position = sb.Length + position;  
                    }
                    while (position > sb.Length)
                    {
                        position = position - sb.Length;
                    }
                }
                numberOfjumps++;
                moves--;
            }
            if (alive == true)
            {

                Console.WriteLine("Coder souls collected: {0}", coderSouls);
                Console.WriteLine("Food collected: {0}", foodCollected);
                Console.WriteLine("Deadlocks: {0}", deadlocks);
            }
            else if (alive == false)
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!");
                Console.WriteLine("Jumps before deadlock: {0}", numberOfjumps);
            }
        }
    }
}
