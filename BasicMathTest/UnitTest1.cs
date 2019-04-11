using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicMath;

namespace BasicMathTest
{
 
    [TestClass]
    public class UnitTest1
    {
 
        [TestMethod]
        public void Test_AddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Add(15, 15);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void Test_SubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Substract(30, 5);
            Assert.AreEqual(res, 25);
        }

        [TestMethod]
        public void Test_DivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Divide(12, 4);
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void Test_MultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.Multiply(30, 2);
            Assert.AreEqual(res, 200);
        }
    }
}
