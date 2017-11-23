using System;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100;

            do
            {
                Console.WriteLine("Counter = {0}", counter);
                counter++;
            }
            while (counter > 2);
        }
    }
}
