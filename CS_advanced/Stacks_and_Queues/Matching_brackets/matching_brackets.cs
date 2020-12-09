using System;
using System.Linq;
using System.Collections.Generic;

namespace Matching_brackets
{
    class matching_brackets
    {
        static void Main(string[] args)
        {
            // input
            string input = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();

            // calculation
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '(')
                {
                    numbers.Push(i);
                }
                else if (symbol == ')')
                {
                    int index = numbers.Pop();
                    string contents = input.Substring(index, i - index + 1);

                    Console.WriteLine(contents);
                }
            }




        }
    }
}
