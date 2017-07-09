using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();
        string text2 = string.Empty;
        StringBuilder sb = new StringBuilder();
        int pause = 0;
        string keyword1 = "<upcase>";
        string keyword2 = "</upcase>";
        int index1 = text.IndexOf(keyword1);
        int index2 = text.IndexOf(keyword2);
        while (index1 != -1 && index2 != -1)
        {
            for (int i = pause; i < index1; i++)
            {
                sb.Append(text[i]);
            }
            for (int i = index1 + keyword1.Length; i < index2; i++)
            {
                text2 += text[i].ToString();
            }
            text2 = text2.ToUpper();
            sb.Append(text2);
            text2 = string.Empty;
            pause = index2 + keyword2.Length;
            index1 = text.IndexOf(keyword1, index1 + 1);
            index2 = text.IndexOf(keyword2, index2 + 1);
            if (index2==-1)
            {
                for (int i = pause; i < text.Length; i++)
                {
                    sb.Append(text[i]);
                }
            }
        }
        Console.WriteLine(sb);
    }
}
