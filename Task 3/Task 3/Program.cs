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
            double y = Math.Sqrt((2 * x + Math.Sin(Math.Abs(3 * x))) / 3.56);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
