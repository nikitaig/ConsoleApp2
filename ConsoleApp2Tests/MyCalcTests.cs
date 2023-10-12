using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class MyCalcTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}

