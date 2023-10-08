using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ChebulaevAG.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат. Условие: Дата некоторого     *");
            Console.WriteLine("* дня характеризуется тремя натуральными числами: g(год),                 *");
            Console.WriteLine("* m(порядковый номер месяца) и n(число). По заданным g, n и m             *");
            Console.WriteLine("* определить дату следующего дня.Заданный год не является високосным.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите год:");
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц (1-12):");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число (1-31):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int daysInMonth = 0;
            bool isValidInput = true;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    // Февраль всегда имеет 28 дней в невисокосном году
                    daysInMonth = 28;
                    break;
                default:
                    Console.WriteLine("Некорректный месяц.");
                    isValidInput = false;
                    break;
            }

            if (isValidInput)
            {
                if (n >= 1 && n <= daysInMonth)
                {
                    if (n < daysInMonth)
                    {
                        Console.WriteLine($"Следующая дата: {n + 1}.{m}.{g}");
                    }
                    else
                    {
                        if (m < 12)
                        {
                            Console.WriteLine($"Следующая дата: 1.{m + 1}.{g}");
                        }
                        else
                        {
                            Console.WriteLine($"Следующая дата: 1.1.{g + 1}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Некорректное число для данного месяца.");
                }
            }

            Console.ReadLine();
        }
    }
}
