using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class CalcTest
    {
        [TestInitialize()]
        public void Init()
        {
            Console.WriteLine("Test init");
        }
        
        [TestMethod]
        public void TestSum()
        {
            Calc calc = new Calc();
            int expected=calc.sum(5,10);
            int actual=15;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubst()
        {
            Calc calc = new Calc();
            int expected = calc.substr(1, 10);
            int actual = -9;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMult()
        {
            Calc calc = new Calc();
            int expected = calc.mult(5, -9);
            int actual = -45;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDiv()
        {
            Calc calc = new Calc();
            double expected = calc.div(99, 9);
            double actual = 11;
            Assert.AreEqual(expected, actual);
        }
       
    }
}
