using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main()
        {
            //string text = Console.ReadLine();
            string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            string text3 = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
            }
            sb.Replace("<a href=\"", "(");
            sb.Replace("\">", ")textHire ");
            sb.Replace("textHire ", "{");
            sb.Replace("</a>", "}");
            var endOfTag = sb.IndexOf("(");
            var endOfUrl = sb.IndexOf(")");
            for (int i = 0; i < sb.Length; i++)
            {
       

                var url = text.Substring(i + 9, endOfUrl - i - 9);
                var body = text.Substring(endOfUrl + 2, endOfTag - endOfUrl - 2);

                sb.Append(string.Format("[{0}]({1})", body, url));
                if (sb[i]=='(' && sb[i]!=')')
                {
                    sb2.Append(sb[i]);
                }
            }
            Console.WriteLine(sb);
            Console.WriteLine(sb2);
        }

    }
}
