using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TaskB6
    {
        [TestMethod]
        public void Test1() => Assert.AreEqual("esrever srettel", Homework.TaskB6.Reverser("reverse letters"), "TEST ERROR");

        [TestMethod]
        public void Test2() => Assert.AreEqual("A nuf elttil !egnellahc", Homework.TaskB6.Reverser("A fun little challenge!"), "TEST ERROR");

        [TestMethod]
        public void Test3() => Assert.AreEqual("  ", Homework.TaskB6.Reverser("  "), "TEST ERROR");
    }
}
