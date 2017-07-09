using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int ZeroLen = 1;
        int bestZeroLen = 0;
        int OneLen = 1;
        int bestOneLen = 0;
        string bits = string.Empty;
        string combineBits = string.Empty;

        for (int i = 0; i < n; i++)
        {
            long numbers = long.Parse(Console.ReadLine());
            bits = Convert.ToString(numbers, 2).PadLeft(30, '0');
            combineBits += bits;
        }
        for (int i = 1; i <combineBits.Length; i++)
        {
            if (combineBits[i-1]==combineBits[i] && combineBits[i]=='0')
            {
                ZeroLen++;
                if (ZeroLen>bestZeroLen)
                {
                    bestZeroLen = ZeroLen;
                }
            }
            else if (combineBits[i-1]==combineBits[i] && combineBits[i]=='1')
            {
                OneLen++;
                if (OneLen>bestOneLen)
                {
                    bestOneLen = OneLen;
                }
            }
            else
            {
                ZeroLen = 1;
                OneLen = 1;
            }
        }
        Console.WriteLine(bestZeroLen);
        Console.WriteLine(bestOneLen);
    }
}
