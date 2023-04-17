using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheesCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            int x2;
            int y2;
            int a;
            Chess chessCheck = new Chess();
            Console.WriteLine("Введите начальную позицию фигуры\n");
            do
            {
                Console.Write("x1 = ");
            }
            while (!int.TryParse(Console.ReadLine(), out x1) || x1 > 8);
            do
            {
                Console.Write("y1 = ");
            }
            while (!int.TryParse(Console.ReadLine(), out y1) || y1 > 8);
            Console.WriteLine("Введите позицию фигуры, на которую хотите походить\n"); do
            {
                Console.Write("x2 = ");
            }
            while (!int.TryParse(Console.ReadLine(), out x2) || x2 > 8);
            do
            {
                Console.Write("y2 = ");
            }
            while (!int.TryParse(Console.ReadLine(), out y2) || y2 > 8);

            Console.WriteLine($"\nИзначальное положение фигуры ({x1} {y1})");

            Console.WriteLine($"\nХотим походить на({x2} {y2})");

            do
            {
                Console.WriteLine();
                Console.WriteLine("Какая шахматная фигура?\n1. Король\n2. Королева\n3. Ладья\n4. Слон\n5. Конь\n6. Пешка\n");
                Console.Write("Ваш выбор: ");
            }
            while ((!int.TryParse(Console.ReadLine(), out a)) || (a > 6));
            Console.WriteLine();
            switch (a)
            {
                case 1:
                    if (chessCheck.King(x1, y1, x2, y2))
                        Console.WriteLine("Ход короля корректный");
                    else Console.WriteLine("Ход короля не корректный");
                    break;
                case 2:
                    if (chessCheck.Queen(x1, y1, x2, y2))
                        Console.WriteLine("Ход королевы корректный");
                    else Console.WriteLine("Ход королевы не корректный");
                    break;
                case 3:
                    if (chessCheck.Rook(x1, y1, x2, y2))
                        Console.WriteLine("Ход ладьи корректный");
                    else Console.WriteLine("Ход ладьи не корректный");
                    break;
                case 4:
                    if (chessCheck.Bishop(x1, y1, x2, y2))
                        Console.WriteLine("Ход слона корректный");
                    else Console.WriteLine("Ход слона не корректный");
                    break;
                case 5:
                    if (chessCheck.Knight(x1, y1, x2, y2))
                        Console.WriteLine("Ход коня корректный");
                    else Console.WriteLine("Ход коня не корректный"); break;
                case 6:
                    if (chessCheck.Pawn(x1, y1, x2, y2))
                        Console.WriteLine("Ход пешки корректный");
                    else Console.WriteLine("Ход пешки не корректный");
                    break;
            }
            Console.ReadKey();
        }
    }
}
