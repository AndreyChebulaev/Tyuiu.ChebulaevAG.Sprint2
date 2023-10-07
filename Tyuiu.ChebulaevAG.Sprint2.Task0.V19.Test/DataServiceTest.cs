using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint2.Task0.V19.Lib;

namespace Tyuiu.ChebulaevAG.Sprint2.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            int x = 105;
            int y = 177;

            bool[] wait = { false, true, true, false, true, false };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
