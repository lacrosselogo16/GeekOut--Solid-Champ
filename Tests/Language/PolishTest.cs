using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class PolishTest:GreetingTests
    {
        public PolishTest()
        {
            _languageName = "Polish";
            _greeting = "Witaj świecie!";
        }
    }
}