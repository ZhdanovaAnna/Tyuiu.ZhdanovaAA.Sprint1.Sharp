using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1, x2 = 1, y1 = 3, y2 = 4;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(false, res);

        }
    }
}
