using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[] 
            {
                "Александр Сергеевич Пушкин",
                "Михаил Юрьевич Лермонтов",
                "Александр Блок",
                "Андрей Вознесенский",
                "Борис Владимирович Заходер"
            };

            foreach (var name in names)
                Console.WriteLine(ShortName(name));

            Console.ReadKey();
        }

        static string ShortName(string fullName)
        {
            var names = fullName.Split();
            return $"{names[0][0]}. {names[1][0]}. {names[2]}";
        }
    }
}
