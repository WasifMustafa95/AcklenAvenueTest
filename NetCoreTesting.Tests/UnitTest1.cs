using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AcklenAvenueTest;

namespace NetCoreTesting.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z = Class1.Add(3,4);
            Assert.AreEqual(7,z);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var z = Class1.Add(3,4);
            Assert.AreEqual(6,z);
        }
    }
}
