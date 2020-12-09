using System;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_string
{
    class Reverse_string
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();

            Stack<char> reversed = new Stack<char>();

            // calculation
            foreach (char item in input)
            {
                reversed.Push(item);
            }

            // output
            while (reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }

        }
    }
}
