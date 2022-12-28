using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;

namespace Tests
{
    [TestClass]
    public class GreetingOneOffTest:GreetingTestsBase
    {
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
        public void FirstNameOnlyTest()
        {
            //Arrange
            var expected = ExpectedGreetingWith();
            string[] args = {_userName};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameOnlyTest()
        {
            //Arrange
            var expected = ExpectedGreetingWith(true);
            string[] args = {_fullName};

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}