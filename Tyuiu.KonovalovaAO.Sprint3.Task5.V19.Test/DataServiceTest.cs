using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint3.Task5.V19.Lib;
namespace Tyuiu.KonovalovaAO.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 79.988;
            Assert.AreEqual(wait, ds.GetSumSumSeries(1, 1, 3, 1, 6));
        }
    }
}
