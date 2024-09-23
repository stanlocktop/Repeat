using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, my name is Vladick:)");
            Console.ResetColor();

            Console.WriteLine("Напишіть Ім'я");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Я люблю " + name);
            Console.ReadKey();
        }
    }
}
