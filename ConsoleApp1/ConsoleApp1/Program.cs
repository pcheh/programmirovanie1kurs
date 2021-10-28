using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = SquareSum(2, SquareSum(3, SquareSum(4, SquareSum(5, 0))));
            Console.WriteLine($"x = {Math.Round(x, 3)}");

            Console.ReadKey();
        }

        static double SquareSum(double a, double b)
        {
            return Math.Sqrt(a + b);
        }
    }
}
