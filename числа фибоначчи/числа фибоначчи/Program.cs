using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace числа_фибоначчи
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение верхней границы");
            var upperBound = ulong.Parse(Console.ReadLine());

            ulong a = 1, b = 0, c;

            do
            {
                c = a + b;
                a = b;
                b = c;

                Console.Write($"{c}, ");

            } while (c < upperBound);

            Console.WriteLine("\b\b  ");

            Console.ReadKey();
        }
    }
}
