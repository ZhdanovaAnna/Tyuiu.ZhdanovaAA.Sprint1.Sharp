using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task4.V22.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5, y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.032, res);
        }
    }
}
