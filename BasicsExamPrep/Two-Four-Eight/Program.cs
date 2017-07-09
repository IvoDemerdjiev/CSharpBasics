using System;


class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double r = 0;
        double result = 0;
        if (b == 2)
        {
            r = a % c;
        }
        if (b == 4)
        {
            r = a + c;
        }
        if (b == 8)
        {
            r = a * c;
        }
        if (r % 4 == 0)
        {
            result = r / 4;
        }
        if (r % 4 != 0)
        {
            result = r % 4;
        }
        Console.WriteLine(result);
        Console.WriteLine(r);
    }
}
