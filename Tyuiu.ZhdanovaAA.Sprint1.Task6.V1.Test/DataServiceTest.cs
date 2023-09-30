using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "1";
            var res = ds.SymbolCode(value);
            Assert.AreEqual(Convert.ToString(49), res);
        }
    }
}
