using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChebulaevAG.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            switch (value)
            {
                case 1:
                    return "пики";
                case 2:
                    return "трефы";
                case 3:
                    return "бубны";
                case 4:
                    return "червы";
                default:
                    return "Недопустимый номер масти";
            }
        }
    }
}
