using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint2.Task5.V11.Lib;

namespace Tyuiu.ChebulaevAG.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay(int g, int m, int n)
        {
            DataService ds = new DataService();

            var res = ds.FindDateOfNextDay(g, m, n);
            // Act
            var wait = (2023, 10, 7, 2023, 10, 8);
            Assert.AreEqual(wait, res);
        }
    }
}
