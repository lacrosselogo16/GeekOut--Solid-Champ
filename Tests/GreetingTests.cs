using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;

namespace Tests
{
    [TestClass]
    public class GreetingTests
    {
        protected string _languageName = "English";
        protected string _greeting = "Hello World!";
        protected string _userName = "Gregory";

        [TestMethod]
        public void BlankArgsTest()
        {
            //Arrange
            var expected = "Hello World!";
            string[] args = {""};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);

        }

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
        public void PassAlternatingCaseLanguageNameTest()
        {
            //Arrange
            var expected = _greeting;
            string[] args = {_languageName};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}