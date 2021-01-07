using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]

    public class VendingMachineTests
    {
        
        [TestMethod]
        public void BalanceTest()
        {
            VendingMachine testingMachine = new VendingMachine();
            Assert.AreEqual(testingMachine.Balance, 0);
            testingMachine.AddFunds(20);
            Assert.AreEqual(testingMachine.Balance, 20);
        }
        [TestMethod]
        public void AddFundsTest()
        {
            VendingMachine testingMachine = new VendingMachine();
            testingMachine.AddFunds(20);
            Assert.AreEqual(testingMachine.Balance, 20);
        }

        [TestMethod]
        public void BuyItemTest()
        {
            VendingMachine testingMachine = new VendingMachine();
            testingMachine.AddFunds(20);
            testingMachine.PurchaseSnack("B2");
            Assert.AreEqual(testingMachine.Inventory["B2"].QuantityInStock, 4);
            Assert.AreEqual(testingMachine.Inventory["B2"].QuantitySold, 1);
        }
        [TestMethod]
        public void ReturnChangeTest()
        {
            VendingMachine testingMachine = new VendingMachine();
            testingMachine.AddFunds(3);
            testingMachine.PurchaseSnack("A2");
            testingMachine.ReturnChange();
            Assert.AreEqual(testingMachine.Balance, 0);
            //A2 is 1.45 to test for coins later
        }
    }
}
