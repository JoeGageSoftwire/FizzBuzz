using System;
using System.Collections.Generic;
using System.Xml;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                List<string> rules = new List<string>();
                if (counter % 3 == 0)
                {
                    rules.Add("Fizz");
                }

                if (counter % 5 == 0)
                {
                    rules.Add("Buzz");
                }

                if (counter % 7 == 0)
                {
                    rules.Add("Bang");
                }

                string output = String.Join("", rules);

                if (output == "")
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(output);
                }
            }
            Console.ReadLine();
        }
    }
}
