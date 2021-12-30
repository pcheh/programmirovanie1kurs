using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachyot
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 3
            Console.WriteLine("Проверка первой гипотезы Гольдбаха");
            Console.WriteLine("Введите чётное натуральное число, большее или равное 4");
            var a = int.Parse(Console.ReadLine());

            if (!IsNumberCorrect(a))
            {
                Console.WriteLine("Число не соответствует условиям");
                Console.ReadKey();
                return;
            }

            var x = 2;
            var y = 2;
            for (x = 2; x<a; x++)
                if (IsPrime(x))
                    for (y = 2; y<=x; y++)
                        if (IsPrime(y))
                            if (x + y == a)
                                Console.WriteLine($"{a} = {x} + {y}");


            Console.ReadKey();
        }

        static bool IsNumberCorrect (int number)
        {
            return number >= 4 && number % 2 == 0;
        }

        static bool IsPrime (int number)
        {
            var result = true;
            for (var i = 2; i < number; i++)
                if (number % i == 0)
                    result = false;
            return result;
        }
    }
}
