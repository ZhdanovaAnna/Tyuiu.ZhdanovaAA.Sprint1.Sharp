using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint1.Task2.V4.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint1.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServcie ds = new DataServcie();
            int value = 5;
            var res = ds.CalculateSquare(value);
            Assert.AreEqual(25, res);
        }
    }
} 
