using System;


namespace BitsToBits
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int ZeroLen = 0;
            int maxZeroLen = 0;
            int OneLen = 0;
            int maxOneLen = 0;
            int lastBit = 5;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & num) >> j;
                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            OneLen++;
                        }
                        else
                        {
                            maxZeroLen = Math.Max(maxZeroLen, ZeroLen);
                            ZeroLen = 0;
                            OneLen = 1;
                        }
                    }
                    else
                    {
                        if (lastBit == 0)
                        {
                            ZeroLen++;
                        }
                        else
                        {
                            maxOneLen = Math.Max(maxOneLen, OneLen);
                            OneLen = 0;
                            ZeroLen = 1;
                        }
                    }
                    lastBit = bit;
                }
            }
            Console.WriteLine(maxOneLen);
            Console.WriteLine(maxZeroLen);
        }
    }
}
