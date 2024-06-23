﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
                Console.WriteLine("No args");
            else
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
        }
    }
}
