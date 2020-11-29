using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDemo.Test
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act

            fromCall = fp.FileExists(@"c:\windows\regedit.exe");

            //Assert

            Assert.IsTrue(fromCall);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNamesDoesNotExist()
        {
            //Arrange
            FileProcess fp = new FileProcess();
            bool fromCall;

            //Act

            fromCall = fp.FileExists(@"");

            //Assert

            Assert.IsFalse(fromCall);
            // Will throw argument exception error
        }
    }
}
