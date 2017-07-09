using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Substring
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string message = Console.ReadLine();
        keyword=keyword.ToLower();
        message = message.ToLower();
        int sum = 0;
        int index = message.IndexOf(keyword);
        while (index != -1)
        {
            sum++;
            index = message.IndexOf(keyword, index + 1);
        }
        Console.WriteLine(sum);
    }
}
