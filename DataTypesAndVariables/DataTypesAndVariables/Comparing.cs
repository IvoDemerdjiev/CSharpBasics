using System;

class Bit
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        long bit3 = (num >> 3) & 1;
        long bit24 = (num >> 24) & 1;
        num = num & (~(1 << 24)) | (bit3 << 24);
        num = num & (~(1 << 3)) | (bit24 << 3);
        long bit4 = (num >> 4) & 1;
        long bit25 = (num >> 25) & 1;
        num = num & (~(1 << 25)) | (bit4 << 25);
        num = num & (~(1 << 4)) | (bit25 << 4);
        long bit5 = (num >> 5) & 1;
        long bit26 = (num >> 26) & 1;
        num = num & (~(1 << 26)) | (bit5 << 26);
        num = num & (~(1 << 5)) | (bit26 << 5);
        Console.WriteLine(num);     
    }
}
