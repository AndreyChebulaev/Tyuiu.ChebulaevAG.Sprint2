using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChebulaevAG.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = GetDaysInMonth(m, g);

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < daysInMonth)
                    {
                        n++;
                    }
                    else if (n == daysInMonth)
                    {
                        n = 1;
                        m++;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < daysInMonth)
                    {
                        n++;
                    }
                    else if (n == daysInMonth)
                    {
                        n = 1;
                        m++;
                    }
                    break;

                case 2:
                    if (IsLeapYear(g))
                    {
                        if (n < 29)
                        {
                            n++;
                        }
                        else if (n == 29)
                        {
                            n = 1;
                            m++;
                        }
                    }
                    else
                    {
                        if (n < 28)
                        {
                            n++;
                        }
                        else if (n == 28)
                        {
                            n = 1;
                            m++;
                        }
                    }
                    break;

                case 12:
                    if (n < daysInMonth)
                    {
                        n++;
                    }
                    else if (n == daysInMonth)
                    {
                        n = 1;
                        m = 1;
                        g++;
                    }
                    break;
            }

            return (g, m, n);
        }

        private int GetDaysInMonth(int month, int year)
        {
            // Реализуйте логику для определения количества дней в месяце
            // Здесь можно использовать свои правила для разных месяцев
            // Например, в феврале может быть 28 или 29 дней, в зависимости от високосности года
            // Для простоты, вы можете вернуть 30 дней для всех месяцев
            return 30;
        }

        private bool IsLeapYear(int year)
        {
            // Реализуйте логику для определения високосного года
            // Например, год високосный, если он делится на 4 без остатка, но не делится на 100 без остатка
            // Или если он делится на 400 без остатка
            // Для простоты, можно всегда возвращать false, чтобы указать, что год не високосный
            return false;
        }
    }
}
