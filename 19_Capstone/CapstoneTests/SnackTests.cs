using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class SnackTests
    {
        [TestMethod]
        public void SnackConstructorTest()
        {
            //arrange
            string[] testArray = new string[] { "B5", "Chips", "499.99", "Luxury Chips" };
            //act
            Snack toTest = new Snack(testArray);
            //assert
            Assert.AreEqual("B5", toTest.SlotLocation);
            Assert.AreEqual("Chips", toTest.Name);
            Assert.AreEqual(499.99M, toTest.Price);
            Assert.AreEqual("Luxury Chips", toTest.SnackClass);
            Assert.AreEqual(5, toTest.QuantityInStock);
            Assert.AreEqual(0, toTest.QuantitySold);
        }

    }
}
