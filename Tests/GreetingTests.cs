using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    //TODO:Add enum for first name and fullname.
    [TestClass]
    public abstract class GreetingTests:GreetingTestsBase
    {
        [TestMethod]
        public void PassLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName};

            //Act and Assert
            TestGreeting(args);
        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName.ToUpper()};

            //Act and Assert
            TestGreeting(args);
        }

        [TestMethod]
        public void PassLowercaseLanguageNameTest()
        {
            //Arrange
            string[] args = {_languageName.ToLower()};

            //Act and Assert
            TestGreeting(args);
        }

        [TestMethod]
        public void PassUserNameAndLanguageNameTest()
        {
            //Arrange
            string[] args = {_userName,_languageName};

            //Act and Assert
            TestGreeting(args, ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassFullUserNameAndLanguageNameTest()
        {
            //Arrange
            string[] args = {_fullName,_languageName};

            //Act and Assert
            TestGreeting(args, ExpectedGreetingWith(true));
        }

        [TestMethod]
        public void PassThreeArgumentsTest()
        {
            //Arrange
            string[] args = {_userName,_languageName, "blah"};

            //Act and Assert
            TestGreeting(args, ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassMixedCaseLanguageNameTest()
        {
            //Arrange
            string[] args = {TestHelper.MixedCase(_languageName)};

            //Act and Assert
            TestGreeting(args);
        }
    }
}