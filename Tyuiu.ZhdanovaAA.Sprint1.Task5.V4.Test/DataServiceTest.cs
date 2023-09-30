using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 34512;
            var res = Convert.ToInt32(ds.SecondsToHours(time));
            Assert.AreEqual(9, res);
        }
    }
}
