using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ItalianTest:GreetingTests
    {
        public ItalianTest()
        {
            _languageName = "Italian";
            _greeting = "Ciao Mondo!";
        }
    }
}