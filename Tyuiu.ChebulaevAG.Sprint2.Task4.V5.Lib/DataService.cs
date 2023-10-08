using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChebulaevAG.Sprint2.Task4.V5.Lib
{
    public class DataService : ISprint2Task4V5
    {
        public double Calculate(double x, double y)
        {
            double z;

            if (x > y + 5)
            {
                z = y * Math.Pow((x + 2) / (y + 5), x);
            }
            else
            {
                z = Math.Round(Math.Pow(x, 2) + 10 * x + (1 / y), 3);
            }

            return Math.Round(z, 3);
        }
    }
}
