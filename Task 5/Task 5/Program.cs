﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5.1\n");
            Console.WriteLine("Введите текст капсом на русском языке");
            string text = Console.ReadLine();
            Console.WriteLine(TranslationToCS(text));

            Console.ReadKey();

            Console.WriteLine("\n5.2\n");

            string str = "трос";   /*сорт, рост*/
            Console.WriteLine(str);
            string sort = string.Empty + str[3] + str[2] + str[1] + str[0];
            string rost = str.Substring(1, 2) + str.Substring(3, 1) + str.Substring(0, 1);

            Console.WriteLine(sort);
            Console.WriteLine(rost);
            Console.ReadKey();

        }

        static string TranslationToCS(string text)
        {
            return text.Replace('А', 'A').
                Replace('Б', '6').
                Replace('В', 'B').
                Replace('Г', 'r').
                Replace('Д', 'D').
                Replace('Е', 'E').
                Replace('Ё', 'E').
                Replace("Ж", "}|{").
                Replace('И', 'u').
                Replace("Й", "u*").
                Replace('К', 'K').
                Replace("Л", "JI").
                Replace('М', 'M').
                Replace('Н', 'H').
                Replace('О', 'O').
                Replace('П', 'n').
                Replace('Р', 'P').
                Replace('С', 'C').
                Replace('Т', 'T').
                Replace('У', 'Y').
                Replace("Ф", "cp").
                Replace('Х', 'X').
                Replace("Ц", "L|").
                Replace('Ч', '4').
                Replace("Ш", "LLI").
                Replace("Щ", "LLL").
                Replace("Ъ", "`b").
                Replace("Ы", "bI").
                Replace('Ь', 'b').
                Replace("Э", "-)").
                Replace("Ю", "IO").
                Replace("Я", "9I");
        }

    }
}
