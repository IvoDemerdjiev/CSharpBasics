using System;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static string FindingText(string text)
    {
        StringBuilder sb = new StringBuilder();
        string keyword = "<a";
        string keyword2 = ">";
        string keyword3 = "<";
        int index = text.IndexOf(keyword);
        int index2 = text.IndexOf(keyword2);
        int index3=text.IndexOf(keyword3);
        while (index!=-1)
        {
            while (index > index2)
            {
                index2 = text.IndexOf(keyword2, index2 + 1);
            }
            while (index2>index3)
	        {
	         index3 = text.IndexOf(keyword3, index3 + 1);
	        }
            for (int i =index2+1; i <index3 ; i++)
            {
                sb.Append(text[i]);
            }
            index = -1;
        }

        return sb.ToString();
    }
    static void Main(string[] args)
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik.com \">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        StringBuilder sb = new StringBuilder();
        string text2 = string.Empty;
        string[] tokens = text.Split('.');
        for (int i = 0; i < text.Length; i++)
        {
            var endOfTag = text.IndexOf("(", i + 9);
            var endOfUrl = text.IndexOf(")", i + 9);

            var url = text.Substring(i + 9, endOfUrl - i - 9);
            var body = text.Substring(endOfUrl + 2, endOfTag - endOfUrl - 2);

            sb.Append(string.Format("[{0}]({1})", body, url));
                sb.Append(text[i]);
        }
    }
}