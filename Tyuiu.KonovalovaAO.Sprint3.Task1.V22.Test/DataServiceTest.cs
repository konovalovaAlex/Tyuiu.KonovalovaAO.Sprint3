using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KonovalovaAO.Sprint3.Task1.V22.Lib;
namespace Tyuiu.KonovalovaAO.Sprint3.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetSumSeries(1.5, 1, 20);
            Assert.AreEqual(res, 3550.301);

        }
    }
}
