using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("First name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}!!!", name, firstName);
        }
    }
}
