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

            Console.ReadKey();
        }

        static bool IsTrue (int n)
        {
            return n % 5 == 0
                && !(n % 7 == 0);
        }
    }
}
