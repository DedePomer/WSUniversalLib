using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTests
{
    [TestClass]
    public class HardTest
    {
        [TestMethod]
        public void GetQuantityForProduct_BigUsualValue()
        {
            int actual, expected;
            expected = 1141971584;
            actual = Calculation.GetQuantityForProduct(3, 1, 150, 2000, 450.2f);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_BigNegativeValueCount()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 150, -200000000, 450.2f);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_BigFloatValueWidh()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 150, 200.1235f, 450.2f);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_BigFloatValueLenght()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 1, 150, 200.1f, 450.2136521561f);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_BigNegativeValueMaterialType()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, -1000, 150, 200.1f, 450.2f);
            Assert.AreEqual(expected, actual);
        }
    }
}

