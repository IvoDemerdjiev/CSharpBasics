using System;


class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int count = 0;
        long sum = 0;
        str = str.Replace("-", ""); 
        for (int i = 1; i < str.Length; i += 2)
        {
            if (char.IsDigit(str[i]))
            {
                sum += str[i] - '0';
                count++;
            }
        }
        Console.Write(count);
        Console.WriteLine(" " + sum);
    }
}
