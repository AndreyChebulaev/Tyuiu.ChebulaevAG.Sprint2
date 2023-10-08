using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChebulaevAG.Sprint2.Tasl7.V8.Lib;

namespace Tyuiu.ChebulaevAG.Sprint2.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Чебулаев А. Г. | РПСб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Чебулаев Андрей Геннадьевич | РПСб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает                           *");
            Console.WriteLine("* исходные данные (вещественные значения) и вычисляет,                    *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координату X:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится внутри заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка находится снаружи заштрихованной области.");
            }

            Console.ReadLine();
        }
    }
}
