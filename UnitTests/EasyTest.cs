using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTests
{
    [TestClass]
    public class EasyTest
    {
        [TestMethod]
        public void GetQuantityForProduct_UsualValue()
        {
            int actual, expected;
            expected = 114146;
            actual = Calculation.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistTypeMaterial()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 3, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NoExistTypeProduct()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(4, 2, 15, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeValueCount()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, -2, 20, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeValueWidth()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, -1, 45);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeValueLenght()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, 5, -3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroValueLenght()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, 5, 0);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_ZeroValueWidth()
        {
            int actual, expected;
            expected = -1;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, 0, 5);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetQuantityForProduct_FloatValueWidth()
        {
            int actual, expected;
            expected = 190;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, 1.5f, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProduct_FloatValueLenght()
        {
            int actual, expected;
            expected = 190;
            actual = Calculation.GetQuantityForProduct(3, 2, 3, 5, 1.5f);
            Assert.AreEqual(expected, actual);
        }
    }
    
}
