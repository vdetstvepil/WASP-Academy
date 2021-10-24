using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TaskC2
    {
        [TestMethod]
        public void Test1() => CollectionAssert.AreEqual(new List<int>() { 4, 0, 0, 1 }, Homework.TaskC2.ChangeCent(29), "TEST ERROR");

        [TestMethod]
        public void Test2() => CollectionAssert.AreEqual(new List<int>() { 1, 1, 1, 3 }, Homework.TaskC2.ChangeCent(91), "TEST ERROR");

        [TestMethod]
        public void Test3() => CollectionAssert.AreEqual(new List<int>() { 0, 0, 0, 0 }, Homework.TaskC2.ChangeCent(0), "TEST ERROR");

        [TestMethod]
        public void Test4() => CollectionAssert.AreEqual(new List<int>() { 2, 1, 2, 4 }, Homework.TaskC2.ChangeCent(127), "TEST ERROR");

        [TestMethod]
        public void Test5() => CollectionAssert.AreEqual(new List<int>() { 3, 0, 0, 0 }, Homework.TaskC2.ChangeCent(3.9), "TEST ERROR");
    }
}
