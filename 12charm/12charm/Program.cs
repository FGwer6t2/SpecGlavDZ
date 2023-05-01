using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12charm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfCharm = new int[12];
            for (int i = 0; i < arrOfCharm.Length; i++)
            {
                arrOfCharm[i] = 2;
            }
            bool startHeavy, startLight;
            int heavyOrLight;
            startHeavy = startLight = false;
            int idFalseCharm;
            int chose;
            Console.WriteLine("Введите какая монетка будет фальшивой и ее вес, а программа попробует найти фальшивую монетку за 3 взвешивания");
            do
            {
                Console.WriteLine("Ввыберите, будет монетка тяжелее или легче\n1) Тяжелее\n2) Легче");
            }
            while (!int.TryParse(Console.ReadLine(), out chose) || chose > 2 || chose < 1);
            switch (chose)
            {
                case 1:
                    startHeavy = true;
                    break;
                case 2:
                    startLight = true;
                    break;
            }
            int charmFalse;
            do
            {
                Console.WriteLine("Ввыберите, какая монетка будет фальшивой (От 1 до 12)");
            }
            while (!int.TryParse(Console.ReadLine(), out charmFalse) || charmFalse > 12 || charmFalse < 1);
            if (startHeavy)
            {
                arrOfCharm[charmFalse - 1]++;
            }
            if (startLight)
            {
                arrOfCharm[charmFalse - 1]--;
            }

            Console.WriteLine("1) Разделяем монеты на 3 кучки (1, 2, 3, 4), (5, 6, 7, 8) и (9, 10, 11, 12) и взвешиваем первые 2 кучки");

            if ((arrOfCharm[0] + arrOfCharm[1] + arrOfCharm[2] + arrOfCharm[3]) == (arrOfCharm[4] + arrOfCharm[5] + arrOfCharm[6] + arrOfCharm[7]))
            {
                Console.WriteLine("Взвешивание дало, что первые 2 кучки монет равны, это значит, что фальшивая монета находится в 3 кучке\n2) Берем заведомо настоящие монеты (1,2,3) и часть монет из 3ьей кучки (9,10,11). Взвешимаем эти монеты");
                if ((arrOfCharm[0] + arrOfCharm[1] + arrOfCharm[2] == arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]))
                {
                    Console.WriteLine("Взвешивние дало, что кучки равны, значит фальшивая монета - 12.\n3)Определяем вес, взвешивая с настоящей монетой 1");
                    if (arrOfCharm[11] > arrOfCharm[0])
                    {
                        Console.WriteLine("12 монета тяжелее");
                        heavyOrLight = 1;
                    }
                    else
                    {
                        Console.WriteLine("12 монета легче");
                        heavyOrLight = 2;
                    }
                    idFalseCharm = 12;
                }
                else
                {
                    if ((arrOfCharm[0] + arrOfCharm[1] + arrOfCharm[2] > arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]))
                    {
                        Console.WriteLine("Взвешивние дало, что первая кучка монеток тяжелее второй, фальшивка среди монеток 9, 10 и 11. При этом фальшивка легче настоящей монеты.\n3) Взвешиваем монетку 9 и 10.");
                        heavyOrLight = 2;
                        if (arrOfCharm[8] == arrOfCharm[9])
                        {
                            Console.WriteLine("Взвешивние дало, что монетка 9 и 10 равны, следовательно фальшивая монета - 11.");
                            idFalseCharm = 11;
                        }
                        else
                        {
                            if (arrOfCharm[8] > arrOfCharm[9])
                            {
                                Console.WriteLine("Взвешивние дало, что монетка 9 тяжелее 10 равны, следовательно фальшивая монета - 10.");
                                idFalseCharm = 10;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивние дало, что монетка 9 легче 10 равны, следовательно фальшивая монета - 9.");
                                idFalseCharm = 9;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Взвешивние дало, что первая кучка монеток легче второй, фальшивка среди монеток 9, 10 и 11. При этом фальшивка тяжелее настоящей монеты.\n3) Взвешиваем монетку 9 и 10.");
                        heavyOrLight = 1;
                        if (arrOfCharm[8] == arrOfCharm[9])
                        {
                            Console.WriteLine("Взвешивние дало, что монетка 9 и 10 равны, следовательно фальшивая монета - 11.");
                            idFalseCharm = 11;
                        }
                        else
                        {
                            if (arrOfCharm[8] > arrOfCharm[9])
                            {
                                Console.WriteLine("Взвешивние дало, что монетка 9 тяжелее 10 равны, следовательно фальшивая монета - 9.");
                                idFalseCharm = 9;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивние дало, что монетка 9 легче 10 равны, следовательно фальшивая монета - 10.");
                                idFalseCharm = 10;
                            }
                        }
                    }
                }
            }
            else
            {
                if ((arrOfCharm[0] + arrOfCharm[1] + arrOfCharm[2] + arrOfCharm[3]) > (arrOfCharm[4] + arrOfCharm[5] + arrOfCharm[6] + arrOfCharm[7]))
                {
                    Console.WriteLine("Взвешивание дало, что первые 1 кучка монет тяжелее второй, это значит, что фальшивка среди этих кучек, а 3ья кучка состоит из настоящих монет\n2) Взвешиваем 2 кучки монет (1,9,10,11) и (5,2,3,4)");
                    if ((arrOfCharm[0] + arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]) == (arrOfCharm[4] + arrOfCharm[1] + arrOfCharm[2] + arrOfCharm[3]))
                    {
                        Console.WriteLine("Взвешивание дало, что кучки равны, это значит, что фальшивка среди монет 6,7,8.\n3) Взвешиваем 6 и 7");
                        if (arrOfCharm[5] == arrOfCharm[6])
                        {
                            Console.WriteLine("Взвешивание дало, что монеты равны, значить фальшивая монета 8. Так как во 2м взвешивании монета 8 была в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче.");
                            idFalseCharm = 8;
                        }
                        else
                        {
                            if (arrOfCharm[5] > arrOfCharm[6])
                            {
                                Console.WriteLine("Взвешивание дало, что 6 монета тяжелее 7. Так как во 2м взвешивании монетки 6 и 7 были в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче. Следовательно фальшивая монета 7");
                                idFalseCharm = 7;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивание дало, что 7 монета тяжелее 6. Так как во 2м взвешивании монетки 6 и 7 были в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче. Следовательно фальшивая монета 6");
                                idFalseCharm = 6;
                            }
                        }
                        heavyOrLight = 2;
                    }
                    else
                    {
                        if ((arrOfCharm[0] + arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]) > (arrOfCharm[4] + arrOfCharm[1] + arrOfCharm[2] + arrOfCharm[3]))
                        {
                            Console.WriteLine("Взвешивание дало, что первая кучка тяжелее, фальшивая монета либо 1, либо 5.\n3) Взвешиваем 1 и 10");
                            if (arrOfCharm[0] == arrOfCharm[9])
                            {
                                Console.WriteLine("Взвешивание дало, что монетки равны, следовательно фальшивая монета 5. Так как во 2м взвешивании монета 5 была в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче");
                                heavyOrLight = 2;
                                idFalseCharm = 5;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивание дало, что монетка 1 тяжелее, следовательно она фальшивая. Во втором взвешивании первая кучка тоже оказалась тяжелее.");
                                heavyOrLight = 1;
                                idFalseCharm = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Взвешивание дало, что вторая кучка тяжелее, фальшивая монета 2, 3 или 4.\n3) Взвешиваем 2 и 3");
                            if (arrOfCharm[1] == arrOfCharm[2])
                            {
                                Console.WriteLine("Взвешивание дало, что монета 2 и 3 равны, следовательно фальшивка 4. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее");
                                heavyOrLight = 1;
                                idFalseCharm = 4;
                            }
                            else
                            {
                                if (arrOfCharm[1] > arrOfCharm[2])
                                {
                                    Console.WriteLine("Взвешивание дало, что монета 2 тяжелее 3. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее, те фальшивая монета - 2");
                                    heavyOrLight = 1;
                                    idFalseCharm = 2;
                                }
                                else
                                {
                                    Console.WriteLine("Взвешивание дало, что монета 2 легче 3. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее, те фальшивая монета - 3");
                                    heavyOrLight = 1;
                                    idFalseCharm = 3;
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Взвешивание дало, что первые 1 кучка монет легче второй, это значит, что фальшивка среди этих кучек, а 3ья кучка состоит из настоящих монет\n2) Взвешиваем 2 кучки монет (5,9,10,11) и (1,6,7,8)");
                    if ((arrOfCharm[4] + arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]) == (arrOfCharm[0] + arrOfCharm[5] + arrOfCharm[6] + arrOfCharm[7]))
                    {
                        Console.WriteLine("Взвешивание дало, что кучки равны, это значит, что фальшивка среди монет 2,3,4.\n3) Взвешиваем 2 и 3");
                        if (arrOfCharm[1] == arrOfCharm[2])
                        {
                            Console.WriteLine("Взвешивание дало, что монеты равны, значить фальшивая монета 4. Так как во 2м взвешивании монета 4 была в кучке, которая перевешивала в малую сторону, значит, что фальшивая монета была легче.");
                            idFalseCharm = 4;
                        }
                        else
                        {
                            if (arrOfCharm[1] > arrOfCharm[2])
                            {
                                Console.WriteLine("Взвешивание дало, что 2 монета тяжелее 3. Так как во 2м взвешивании монетки 2 и 3 были в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче. Следовательно фальшивая монета 3");
                                idFalseCharm = 3;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивание дало, что 3 монета тяжелее 2. Так как во 2м взвешивании монетки 2 и 3 были в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче. Следовательно фальшивая монета 2");
                                idFalseCharm = 2;
                            }
                        }
                        heavyOrLight = 2;
                    }
                    else
                    {
                        if ((arrOfCharm[4] + arrOfCharm[8] + arrOfCharm[9] + arrOfCharm[10]) > (arrOfCharm[0] + arrOfCharm[5] + arrOfCharm[6] + arrOfCharm[7]))
                        {
                            Console.WriteLine("Взвешивание дало, что первая кучка тяжелее, фальшивая монета либо 5, либо 1.\n3) Взвешиваем 5 и 10");
                            if (arrOfCharm[4] == arrOfCharm[9])
                            {
                                Console.WriteLine("Взвешивание дало, что монетки равны, следовательно фальшивая монета 1. Так как во 2м взвешивании монета 1 была в кучке, которая перевешивала в малую сторону, то значит, что фальшивая монета была легче");
                                heavyOrLight = 2;
                                idFalseCharm = 1;
                            }
                            else
                            {
                                Console.WriteLine("Взвешивание дало, что монетка 5 тяжелее, следовательно она фальшивая. Во втором взвешивании первая кучка тоже оказалась тяжелее.");
                                heavyOrLight = 1;
                                idFalseCharm = 5;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Взвешивание дало, что вторая кучка тяжелее, фальшивая монета 6, 7 или 8.\n3) Взвешиваем 6 и 7");
                            if (arrOfCharm[5] == arrOfCharm[6])
                            {
                                Console.WriteLine("Взвешивание дало, что монета 6 и 7 равны, следовательно фальшивка 8. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее");
                                heavyOrLight = 1;
                                idFalseCharm = 8;
                            }
                            else
                            {
                                if (arrOfCharm[5] > arrOfCharm[6])
                                {
                                    Console.WriteLine("Взвешивание дало, что монета 6 тяжелее 7. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее, те фальшивая монета - 6");
                                    heavyOrLight = 1;
                                    idFalseCharm = 6;
                                }
                                else
                                {
                                    Console.WriteLine("Взвешивание дало, что монета 6 легче 7. Во втором взвешивании вторая кучка тяжелее, следовательно и фальшивая монета тяжелее, те фальшивая монета - 7");
                                    heavyOrLight = 1;
                                    idFalseCharm = 7;
                                }
                            }
                        }
                    }
                }
            }
            string height = "";
            if (heavyOrLight == 1)
            {
                height = "тяжелее";
            }
            if (heavyOrLight == 2)
            {
                height = "легче";
            }
            Console.WriteLine($"\nСистема думает, что фальшивая монета - {idFalseCharm} и она {height} настоящей");
            Console.ReadKey();
        }
    }
}
