using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests:GreetingTestsBase
    {
        [TestMethod]
        public void PassLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName};

            //Act and Assert
            Test(args);
        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName.ToUpper()};

            //Act and Assert
            Test(args);
        }

        [TestMethod]
        public void PassLowercaseLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName.ToLower()};

            //Act and Assert
            Test(args);
        }

        [TestMethod]
        public void PassUserNameAndLanguageNameTest()
        {
            //Arrange
            string[] args = {_userName,_languageName};

            //Act and Assert
            Test(args, ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassFullUserNameAndLanguageNameTest()
        {
            //Arrange
            string[] args = {_fullName,_languageName};

            //Act and Assert
            Test(args, ExpectedGreetingWith(true));
        }

        [TestMethod]
        public void PassThreeArgumentsTest()
        {
            //Arrange
            string[] args = {_userName,_languageName, "blah"};

            //Act and Assert
            Test(args, ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassMixedCaseLanguageNameTest()
        {
            //Arrange
            string[] args = {TestHelper.MixedCase(_languageName)};

            //Act and Assert
            Test(args);
        }
    }
}