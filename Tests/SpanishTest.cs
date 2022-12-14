using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class SpanishTest:GreetingTests
    {
        public SpanishTest()
        {
            _languageName = "Spanish";
            _greeting = "Hola Mundo!";
        }
    }
}