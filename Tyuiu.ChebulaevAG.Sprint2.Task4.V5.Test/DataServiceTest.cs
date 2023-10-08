using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint2.Task4.V5.Lib;

namespace Tyuiu.ChebulaevAG.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 200.2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 200.067;
            Assert.AreEqual(wait, res);
        }
    }
}
