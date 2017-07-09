using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            ParseURL(text);
        }
        static void ParseURL(string text)
        {
            StringBuilder protocol=new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();
            int count = 0;
            string keyword1 = "://";
            int index = text.IndexOf(keyword1);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='/')
                {
                    count++;
                }
                if (i<index)
                {
                    protocol.Append(text[i]);
                }
                if (i>index && text[i]!='/' && count<3)
                {
                    server.Append(text[i]);
                }
                if (count>=3)
                {
                    resource.Append(text[i]);
                }
            }
            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
