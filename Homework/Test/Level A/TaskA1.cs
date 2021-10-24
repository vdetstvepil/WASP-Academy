using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TaskA1
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual(0, Homework.TaskA1.NumberOfSquares(1), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual(1, Homework.TaskA1.NumberOfSquares(2), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.AreEqual(1, Homework.TaskA1.NumberOfSquares(5), "TEST ERROR");

        [TestMethod]
        public void Test4() => Assert.AreEqual(2, Homework.TaskA1.NumberOfSquares(6), "TEST ERROR");

        [TestMethod]
        public void Test5() => Assert.AreEqual(3, Homework.TaskA1.NumberOfSquares(15), "TEST ERROR");

        [TestMethod]
        public void Test6() => Assert.AreEqual(6, Homework.TaskA1.NumberOfSquares(100), "TEST ERROR");
    }
}
