using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberOperationTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddDigitsTest()
        {
            int number = 1365;

            Number add = new Number();

            int sum = add.AddDigits(number);

            Assert.AreEqual(15, sum);
        }
    }
}
