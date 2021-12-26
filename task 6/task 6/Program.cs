using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //вариант 3
            Console.WriteLine("Введите целое число");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {n} кратно 5, но не кратно 7: {IsTrue(n)}");

            Console.WriteLine("-------------------");

            Console.WriteLine("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Точка принадлежит указанной области: {IsInsideArea(x, y)}");

            Console.WriteLine("-------------------");

            //Белая ладья и чёрный конь

            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию чёрного коня");
            var blackKnightPosition = Console.ReadLine();

            if (!ArePositionsCorrect(whiteRookPosition, blackKnightPosition))
            {
                Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белой ладьи");
            var move = Console.ReadLine();

            if (CanRookMakeSafeMove(whiteRookPosition, blackKnightPosition, move))
                Console.WriteLine($"Ладья {whiteRookPosition} может безопасно пойти на клетку {move}");
            else
                Console.WriteLine($"Ладья {whiteRookPosition} не может пойти на клетку {move}");

            Console.ReadKey();
        }


        static bool ArePositionsCorrect(string rookPosition, string knightPosition)
        {
            return !ArePositionsEqual(rookPosition, knightPosition) &&
                !DoesRookStrikeKnight(rookPosition, knightPosition) &&
                !DoesKnightStrikeRook(rookPosition, knightPosition);
        }

        static bool CanRookMakeSafeMove(string rookPosition, string knightPosition, string move)
        {
            return CanRookMove(rookPosition, move) &&
                !DoesKnightStrikeRook(move, knightPosition);
        }

        static bool ArePositionsEqual(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool DoesKnightStrikeRook(string rookPosition, string knightPosition)
        {
            int rx, ry, kx, ky;

            (ry, rx) = GetCoordinates(rookPosition);
            (ky, kx) = GetCoordinates(knightPosition);

            return (Math.Abs(ky - ry) == 1 && Math.Abs(kx - rx) == 2) ||
                (Math.Abs(ky - ry) == 2 && Math.Abs(kx - rx) == 1);
        }

        static bool DoesRookStrikeKnight(string rookPosition, string knightPosition)
        {
            return CanRookMove(rookPosition, knightPosition);
        }

        static bool CanRookMove(string rookPosition, string move)
        {
            int rx, ry, mx, my;
            (ry, rx) = GetCoordinates(rookPosition);
            (my, mx) = GetCoordinates(move);

            return ry == my || rx == mx;
        }

        static (int, int) GetCoordinates(string position)
        {
            var row = (int)position[1] - 0x31;
            var column = (int)position[0] - 0x61;

            return (row, column);
        }

        static bool IsTrue (int n)
        {
            return n % 5 == 0 &&
                !(n % 7 == 0);
        }

        static bool IsInsideArea (double x, double y)
        {
            return (x >= 2 && y >= 0) || (x >= 1 && y <= (-1));
        }

    }
}
