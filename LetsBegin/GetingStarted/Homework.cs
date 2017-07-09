using System;

namespace GetingStarted
{
    class Homework
    {
        static void Main()
        {
            string hello = "Hello ";
            string world="world";
            object combine = hello + world;
            Console.WriteLine(combine);
            string hiWorld = (string)combine;
            Console.WriteLine(hiWorld);
        }
    }
}
