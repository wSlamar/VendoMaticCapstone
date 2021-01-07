using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class LoaderTests
    {
        [TestMethod]
        public void LoaderTest()
        {
            //arrange
            //First snack
            string[] firstArray = new string[] { "A1", "Potato Crisps", "3.05", "Chip" };
            Snack firstSnack = new Snack(firstArray);
            //Middle snack
            string[] middleArray = new string[] { "C1","Cola","1.25","Drink" };
            Snack middleSnack = new Snack(middleArray);
            //Last snack
            string[] lastArray = new string[] { "D4","Triplemint","0.75","Gum" };
            Snack lastSnack = new Snack(lastArray);
            //act
            SortedDictionary<string, Snack> loaderTestDictionary = Loader.SnackLoader();
            //assert

            Assert.AreEqual(loaderTestDictionary["A1"].SlotLocation, firstSnack.SlotLocation);
            Assert.AreEqual(loaderTestDictionary["A1"].Name, firstSnack.Name);
            Assert.AreEqual(loaderTestDictionary["A1"].Price, firstSnack.Price);
            Assert.AreEqual(loaderTestDictionary["A1"].SnackClass, firstSnack.SnackClass);

            Assert.AreEqual(loaderTestDictionary["C1"].SlotLocation, middleSnack.SlotLocation);
            Assert.AreEqual(loaderTestDictionary["C1"].Name, middleSnack.Name);
            Assert.AreEqual(loaderTestDictionary["C1"].Price, middleSnack.Price);
            Assert.AreEqual(loaderTestDictionary["C1"].SnackClass, middleSnack.SnackClass);

            Assert.AreEqual(loaderTestDictionary["D4"].SlotLocation, lastSnack.SlotLocation);
            Assert.AreEqual(loaderTestDictionary["D4"].Name, lastSnack.Name);
            Assert.AreEqual(loaderTestDictionary["D4"].Price, lastSnack.Price);
            Assert.AreEqual(loaderTestDictionary["D4"].SnackClass, lastSnack.SnackClass);
        }
    }
}
