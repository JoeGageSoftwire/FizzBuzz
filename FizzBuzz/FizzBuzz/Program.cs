﻿using System;
using System.Xml;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter < 101; counter++)
            {
                if ( counter % 3 == 0 && counter % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( counter % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
            Console.ReadLine();
        }
    }
}
