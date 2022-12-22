using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests:ArgFactory
    {
        [TestMethod]
        public void CreateLanguageOnlyTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.LANGUAGE_ONLY)[0]);
        }

        [TestMethod]
        public void CreateLanguageOnlyWithUpperCaseTest()
        {
            Assert.AreEqual(_languageName.ToUpper(), Create(ArgType.LANGUAGE_ONLY_UPPERCASE)[0]);
        }
        [TestMethod]
        public void CreateLanguageOnlyWithLowerCaseTest()
        {
            Assert.AreEqual(_languageName.ToLower(), Create(ArgType.LANGUAGE_ONLY_LOWERCASE)[0]);
        }
        [TestMethod]
        public void CreateLanguageOnlyWithMixedCaseTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.LANGUAGE_ONLY_MIXEDCASE)[0]);
        }
        [TestMethod]
        public void CreateFirstNameWithLanguageTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FIRSTNAME_WITH_LANGUAGE)[0]);
        }
        [TestMethod]
        public void CreateFullNameWithLanguageTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FULLNAME_WITH_LANGUAGE)[0]);
        }
        [TestMethod]
        public void CreateFirstNameLanguageAndThirdConditionTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER)[0]);
        }
        [TestMethod]
        public void CreateNullTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.NULL)[0]);
        }
/***************************************************************************************/
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