using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана длина ребра куба. Найти его объем и длину диагонали.
            Console.WriteLine("Введите длину ребра куба");
            double rebro = double.Parse(Console.ReadLine());
            double objem = Math.Pow(rebro, 3);
            double diagonal = Math.Sqrt(3) * (rebro);
            Console.WriteLine($"объем = {objem}");
            Console.WriteLine($"Диагональ куба = {diagonal}");
            Console.ReadKey();
        }
    }
}
