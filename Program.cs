﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
        }
    }
}