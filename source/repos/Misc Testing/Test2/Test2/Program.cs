﻿using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            switch(years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }

            /*
            if (years == 0)
                Console.WriteLine("Inexperienced");

            else if (years == 1)
                Console.WriteLine("Junior");

            else if (years == 2)
                Console.WriteLine("Intermediate");

            else if (years == 3)
                Console.WriteLine("Advanced");

            else
                Console.WriteLine("Senior");
            */

        }
    }
}
