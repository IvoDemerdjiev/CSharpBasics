using System;



class Program
{
    static void Main(string[] args)
    {
        int p = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array=new int [k];
        int n = 0;
        for (int i = 0; i < k; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            n = array[i];
            string str1 = string.Empty;
            string str2 = string.Empty;
            str1 = Convert.ToString(n, 2);
            str2 = Convert.ToString(p, 2);
            char[] cArray1 = str2.ToCharArray();
            for (int j = 0; j < cArray1.Length; j++)
            {
                if (cArray1[j] != '0')
                {
                    cArray1[j] = '0';
                }
            }
            char[] cArray3 = str2.ToCharArray();
            string reverse3 = String.Empty;
            for (int m = cArray3.Length - 1; m > -1; m--)
            {
                reverse3 += cArray3[m];
            }
            str2 = reverse3;
            string s = new string(cArray1);
            char[] cArray = str1.ToCharArray();
            string reverse = String.Empty;
            for (int m = cArray.Length - 1; m > -1; m--)
            {
                reverse += cArray[m];
            }
            string correctString = reverse.Replace(str2, s);

            char[] cArray2 = correctString.ToCharArray();
            string reverse2 = String.Empty;
            for (int g = cArray2.Length - 1; g > -1; g--)
            {
                reverse2 += cArray2[g];
            }
            long l = Convert.ToInt64(reverse2, 2);
            Console.WriteLine(l);
        }
    }
}
