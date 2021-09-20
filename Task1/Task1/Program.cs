using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ода о мухе и варенье");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Села муха на варенье - вот и все стихотворение");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
