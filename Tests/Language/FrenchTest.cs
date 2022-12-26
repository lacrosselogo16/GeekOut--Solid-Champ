using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class FrenchTest:GreetingTests
    {
        public FrenchTest()
        {
            this._languageName = "French";
            this._greeting = "Bonjour le monde!";
        }
    }
}