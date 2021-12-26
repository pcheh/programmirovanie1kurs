using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
            //вариант 3
        {
            Console.WriteLine("Введите целое число");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Число {n} кратно 5, но не кратно 7: {IsTrue(n)}");

            Console.WriteLine("----------------");

            Console.WriteLine("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Точка принадлежит указанной области: {IsInsideArea(x, y)}");

            Console.ReadKey();
        }

        static bool IsTrue (int n)
        {
            return n % 5 == 0
                && !(n % 7 == 0);
        }

        static bool IsInsideArea(double x, double y)
        {
            return (x >= 2 && y >= 0) || (x >= 1 && y <= (-1));
        }
    }
}
