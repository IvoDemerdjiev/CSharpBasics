using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigElement
{
    class Program
    {
        static Boolean CompareElements(int[] arr,int position)
        {
            if (arr[position - 1] < arr[position] && arr[position] > arr[position + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int CheckALL(int[] arr)
        {
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (CompareElements(arr,i))
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 3, 3, 3, 5, 3 };
           int result=CheckALL(arr);
           if (result!=-1)
           {
               Console.WriteLine("The element is in position {0}",result);
           }
           else
           {
               Console.WriteLine("-1");
           }
        }
    }
}
