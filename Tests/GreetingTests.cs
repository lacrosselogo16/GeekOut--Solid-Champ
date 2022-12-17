using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests
    {
        protected string _languageName = "English";
        protected string _greeting = "Hello World!";
        protected string _userName = "Gregory";

        [TestMethod]
        public void PassLanguageNameTest()
        {
            //Arrange
            var expected = _greeting;
            string[] args = {_languageName};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            //Arrange
            var expected = _greeting;
            string[] args = {_languageName.ToUpper()};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassLowercaseLanguageNameTest()
        {
            //Arrange
            var expected = _greeting;
            string[] args = {_languageName.ToLower()};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassUserNameAndLanguageNameTest()
        {
            //Arrange
            var expected = _userName + "\r\n" + _greeting;
            string[] args = {_userName,_languageName};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassThreeArgumentsTest()
        {
            //Arrange
            var expected = _userName + "\r\n" + _greeting;
            string[] args = {_userName,_languageName, "blah"};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PassMixedCaseLanguageNameTest()
        {
            //Arrange
            var expected = _greeting;
            string[] args = {TestHelper.MixedCase(_languageName)};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}