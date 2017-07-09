using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BadCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string text = string.Empty;
        string position = string.Empty;
        LinkedList<string> linked = new LinkedList<string>();
        for (int i = 0; i < n; i++)
        {
            text = Console.ReadLine();
            char[] separator = new char[] { ' ' };
            string[] Arr = text.Split(separator);
            position = Arr[2];
            if (i == 0 || (linked.Contains(Arr[0]) == false && linked.Contains(Arr[3]) == false))
            {
                if (linked.Contains(Arr[0]) == false && position == "before")
                {
                    linked.AddFirst(Arr[0]);
                    LinkedListNode<string> node = linked.Find(Arr[0]);
                    linked.AddAfter(node, Arr[3]);

                }
                if (linked.Contains(Arr[0]) == false && position == "after")
                {
                    linked.AddFirst(Arr[3]);
                    LinkedListNode<string> node2 = linked.Find(Arr[3]);
                    linked.AddAfter(node2, Arr[0]);
                }
            }
            else
            {
                /*1 is before 2
                  4 is after 2
                  3 is before 4
                  6 is after 4
                  6 is before 8*/
                LinkedListNode<string> node = linked.Find(Arr[0]);
                LinkedListNode<string> node2 = linked.Find(Arr[3]);
                if (linked.Contains(Arr[0]) == false && position == "before")
                {
                    linked.AddBefore(node2, Arr[0]);
                }
                if (linked.Contains(Arr[0]) == false && position == "after")
                {
                    linked.AddAfter(node2, Arr[0]);
                }
                if (position == "after" && linked.Contains(Arr[3]) == false)
                {
                    linked.AddBefore(node, Arr[3]);
                }
                if (position == "before" && linked.Contains(Arr[3]) == false)
                {
                    linked.AddAfter(node, Arr[3]);
                }
            }
        }
        foreach (var value in linked)
        {
            Console.Write(value);
        }
        Console.WriteLine();
    }
}
