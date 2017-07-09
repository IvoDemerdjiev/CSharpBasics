using System;



class Program
{
    static void Main()
    {
        char asc = '+';
        Console.WriteLine(Convert.ToInt32(asc));
        string str = "(1+9)%6–(7%2)*8";
        int number = 0;
        int sum = 0;
        int sum2 = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (Convert.ToInt32(str[i])==40)
            {
                sum2 = 0;
                i++;
                while (Convert.ToInt32(str[i])!=41)
                {
                    if (char.IsDigit(str[i]))
                    {
                        number = str[i] - '0';
                        sum2 += number;
                        i++;
                    }
                    if (Convert.ToInt32(str[i])==43)
                    {
                        i++;
                        sum2 += str[i] - '0';
                        i++;
                    }
                    if (Convert.ToInt32(str[i]) == 45)
                    {
                        i++;
                        sum2 -= str[i] - '0';
                        i++;
                    }
                    if (Convert.ToInt32(str[i]) == 37)
                    {
                        i++;
                        sum2 %= str[i] - '0';
                        i++;
                    }
                    if (Convert.ToInt32(str[i]) == 42)
                    {
                        i++;
                        sum2 *= str[i] - '0';
                        i++;
                    }
                    sum = sum2;
                }
            }
            if (char.IsDigit(str[i]))
            {
                number = str[i] - '0';
                sum += number;
            }
            if (Convert.ToInt32(str[i]) == 43)
            {
                i++;
                sum += str[i] - '0';
            }
            if (Convert.ToInt32(str[i]) == 45)
            {
                i++;
                sum -= str[i] - '0';
            }
            if (Convert.ToInt32(str[i]) == 37)
            {
                i++;
                sum %= str[i] - '0';
            }
            if (Convert.ToInt32(str[i]) == 42)
            {
                i++;
                sum *= str[i] - '0';
            }
        }
    }
}
