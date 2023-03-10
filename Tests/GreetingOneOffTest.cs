using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;

namespace Tests
{
    [TestClass]
    public class GreetingOneOffTest
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
    }
}