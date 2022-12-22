using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldProgram.BusinessLogic;

namespace Tests
{
    public abstract class GreetingTestsBase
    {
        protected string _languageName = "English";
        protected string _greeting = "Hello World!";
        protected string _userName = "Gregory";
        protected string _fullName = "Gregory Jones";

        protected void TestGreeting(string[] args, string expected = "")
        {
            //Arrange
            expected = (expected == "")?_greeting:expected;

            //Act
            var actual = GreetingFactory.Create(args).Display();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        protected string ExpectedGreetingWith(bool isFullName = false)
        {

            return ((isFullName)?_fullName:_userName) + "\r\n" + _greeting;
        } 
    }
}