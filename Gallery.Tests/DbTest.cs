using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gallery.Tests
{
    [TestClass]
    public class DbTest
    {

        [TestMethod]
        public void TestInsert()
        {
            Assert.AreNotEqual(
                notExpected: 0,
                actual: 1);
        }
    }
}
