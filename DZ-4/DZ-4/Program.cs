using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[8, 6];
            //Первоначальное заполнение массива
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                int boolTrue = i;
                for (int j = 2; j >= 0; j--)
                {
                    tab[i, j] = boolTrue & 1;
                    boolTrue >>= 1;
                }
            }
            //Антидизьюнкция. Действие x ↓ y
            for (int i = 0; i < 8; i++)
            {
                if (tab[i, 1] == tab[i, 2] && tab[i, 1] == 0) tab[i, 3] = 1;
                else tab[i, 3] = 0;
            }
            //Дизьюнкция. Действие x + (x ↓ y)
            for (int i = 0; i < 8; i++)
            {
                if (tab[i, 0] == 1 || tab[i, 3] == 1) tab[i, 4] = 1;
                else tab[i, 4] = 0;
            }
            //Дизьюнкция. Действие (x + ( y ↓ z)) + y
            for (int i = 0; i < 8; i++)
            {
                if (tab[i, 1] == 1 || tab[i, 4] == 1) tab[i, 5] = 1;
                else tab[i, 5] = 0;
            }
            //Вывод таблицы
            Console.WriteLine("--------------------");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{tab[i, j].ToString()} |");
                }  
                Console.WriteLine();
                Console.WriteLine("--------------------");
            }
            Console.ReadKey();

        }

    }
}
