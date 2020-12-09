using System;
using System.Linq;
using System.Collections.Generic;

namespace utility_methods
{
    class utilithy_methods
    {
        static void Main(string[] args)
        {
            // input
            Stack<int> input = new Stack<int>();

            for (int i = 0; i < 10; i++)
            {
                input.Push(i);
            }

            int count = input.Count();
            bool exists = input.Contains(20);

            Console.WriteLine(count);
            Console.WriteLine(exists);
        }
    }
}
