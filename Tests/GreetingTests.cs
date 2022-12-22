using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests:ArgFactory
    {
        [TestMethod]
        public void PassLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY));
        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY_UPPERCASE));
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