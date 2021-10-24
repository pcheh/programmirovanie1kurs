using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"y = {CountY(x)}");

            Console.ReadKey();
        }

        static double CountY (double x)
        {
            return Math.Sqrt((2 * x + Math.Sin(Math.Abs(3 * x))) / 3.56);
        }
    }
}
