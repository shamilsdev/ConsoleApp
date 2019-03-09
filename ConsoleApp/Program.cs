using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}!!!", name, lastName);
        }
    }
}
