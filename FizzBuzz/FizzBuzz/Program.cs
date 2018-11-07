using System;
using System.Collections.Generic;
using System.Xml;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 150; counter++)
            {
                List<string> rules = new List<string>();
                if (counter % 3 == 0)
                {
                    rules.Add("Fizz");
                }

                if (counter % 13 == 0)
                {
                    rules.Add("Fezz");
                }

                if (counter % 5 == 0)
                {
                    rules.Add("Buzz");
                }

                if (counter % 7 == 0)
                {
                    rules.Add("Bang");
                }

                if (counter % 11 == 0)
                {
                    rules.Remove("Fizz");
                    rules.Remove("Buzz");
                    rules.Remove("Bang");
                    rules.Add("Bong");
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
