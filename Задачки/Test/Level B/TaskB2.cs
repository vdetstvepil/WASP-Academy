using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TaskB2
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 2000, 103, 123, 4444, 99 }, 
            Homework.TaskB2.OrderWeight(new List<int>() { 103, 123, 4444, 99, 2000 }), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 11, 11, 2000, 10003, 22, 123, 1234000, 44444444, 9999 },
            Homework.TaskB2.OrderWeight(new List<int>() { 2000, 10003, 1234000, 44444444, 9999, 11, 11, 22, 123 }), "TEST ERROR");
    }
}
