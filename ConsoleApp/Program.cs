﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("First name: ");
            var firstName = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();

            Console.Write("Dob: ");
            var dob = Console.ReadLine();

            Console.WriteLine("Hello {0} {1} {2}!", firstName, name, lastName);
            Console.WriteLine("Your age is: {0}", (DateTime.Parse(dob) - DateTime.Today));
        }
    }
}
