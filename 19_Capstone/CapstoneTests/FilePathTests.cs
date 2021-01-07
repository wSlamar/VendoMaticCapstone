using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class FilePathTests
    {
        [TestMethod]

        public void FilePathTest()
        {
            Assert.IsTrue(File.Exists(Loader.LoadFileLocation));
           
        }

    }
}
