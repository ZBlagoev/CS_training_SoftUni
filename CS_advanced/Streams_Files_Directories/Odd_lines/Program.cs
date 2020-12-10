using System;
using System.IO;

namespace Odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            var reader = new StreamReader("input.txt");

            using (reader)
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
