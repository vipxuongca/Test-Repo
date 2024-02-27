﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers: ");
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"The sum of {a} and {b} is {Utility.Sum(a, b)}");
            Console.WriteLine("Enter any key to close...");
            Console.ReadLine();
        }
    }
}