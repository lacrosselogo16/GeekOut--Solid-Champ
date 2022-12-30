using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;
using HelloWorldProgram.BusinessLogic.Interfaces;

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
        [TestMethod]
        public void HelpMenuTest()
        {
            //Arrange
            string expected = GetExpectedHelpMenu();
            string[] args = {"help"};

            //Act
            IDisplayable helpMenu = GreetingFactory.Create(args);
            string actual = helpMenu.Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private string GetExpectedHelpMenu()
        {
            var helpMenuExpected = new StringBuilder();
            helpMenuExpected.AppendLine("Input <Name> <Language>");
            helpMenuExpected.AppendLine();
            helpMenuExpected.AppendLine("Example:");
            helpMenuExpected.AppendLine("\tHello");
            helpMenuExpected.AppendLine("\tHello Tiffany");
            helpMenuExpected.AppendLine("\tHello Tiffany French");
            helpMenuExpected.AppendLine("\tHello French");
            helpMenuExpected.AppendLine("\tHello help");
            helpMenuExpected.AppendLine();
            helpMenuExpected.AppendLine("Listed Active Languages:");
            var a = new Greeting(new string[]{});
            foreach(var greeting in a.Greetings)
            {
                helpMenuExpected.AppendLine("\t"+greeting.Key);
            }
            
            return helpMenuExpected.ToString();
        }
    }
}