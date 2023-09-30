using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task1.V13.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(2, res);
        }
    }
}
