using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChebulaevAG.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a == b) && (c == d);
            results[1] = (a != b) && (c == d);
            results[2] = (a < b) && (c < d);
            results[3] = (a > b) || (c > d);
            results[4] = (a <= b) || (c <= d);
            results[5] = (a >= b) || (c >= d);

            return results;
        }
    }
}
