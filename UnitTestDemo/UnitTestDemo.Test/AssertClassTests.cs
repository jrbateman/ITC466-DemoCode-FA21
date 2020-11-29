using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.PersonClasses;



namespace UnitTestDemo.Test
{
    [TestClass]
    public class AssertClassTests
    {

        #region AreEqual/AreNotEqual Tests

        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "GoBears";
            string str2 = "GoBears";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "GoBears";
            string str2 = "goBears";

            Assert.AreEqual(str1, str2, false);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "MissouriState";
            string str2 = "MSU";

            Assert.AreNotEqual(str1, str2);

        }


        #endregion

        #region AreSame/AreNotSame Tests

        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }


        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }

        #endregion

        #region IsInstanceOfType Test

        [TestMethod]
        public void IsInstanceIfTypeTest()
        {
            //Arrange
            PersonManager mgr = new PersonManager();
            Person per;

            // Act
            per = mgr.CreatePerson("James", "Bateman", true);


            //Assert

            Assert.IsInstanceOfType(per, typeof(Supervisor));

        }

        [TestMethod]
        public void IsNullTest()
        {
            //Arrange
            PersonManager mgr = new PersonManager();
            Person per;


            //Act
            per = mgr.CreatePerson("", "Bateman", true);

            //Assert
            Assert.IsNull(per);

        }



        #endregion

        #region StringAsserts

        [TestMethod]
        public void ContainsTest()
        {
            string str1 = "Go Bears";
            string str2 = "Bears";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        public void StartsWithTest()
        {
            string str1 = "All Lower Case";
            string str2 = "All Lower";

            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]

        public void IsAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("all lower case", r);
        }


        [TestMethod]
        public void IsNotAllLowerCaseTest()
        {
            Regex r = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("All Lower Case", r);


            #endregion

        }
    }
}
