using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChebulaevAG.Sprint2.Task6.V4.Lib;

namespace Tyuiu.ChebulaevAG.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();
            int value = 4;
            string res = ds.FindCardSuit(value);
            string wait = "червы";
            Assert.AreEqual(wait, res);
        }
    }
}
