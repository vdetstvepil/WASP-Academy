using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TaskA2
    {
        [TestMethod]
        public void Test1() => Assert.IsTrue(Homework.TaskA2.VeryEven(4), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.IsFalse(Homework.TaskA2.VeryEven(5), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.IsFalse(Homework.TaskA2.VeryEven(12), "TEST ERROR");

        [TestMethod]
        public void Test4() => Assert.IsFalse(Homework.TaskA2.VeryEven(1234), "TEST ERROR");

        [TestMethod]
        public void Test5() => Assert.IsTrue(Homework.TaskA2.VeryEven(7897), "TEST ERROR");
    }
}
