using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 3
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("f(x) = " + CountFunction(x));

            Console.ReadKey();
        }

        static double CountFunction (double x)
        {
            if (x > 2)
                return 2;
            else
                if (x > 0 && x <= 2)
                    return 0;
                return -3 * x;
        }
    }
}
