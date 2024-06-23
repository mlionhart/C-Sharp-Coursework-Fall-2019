﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // Use the get/set methods to interact with the object's name.
            emp.Name = "Marv";
            Console.WriteLine("Employee is name: {0}", emp.Name);
            Console.ReadLine();
        }
    }
}
