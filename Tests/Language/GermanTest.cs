using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class GermanTest:GreetingTests
    {
        public GermanTest()
        {
            this._languageName = "German";
            this._greeting = "Hallo Welt!";
        }
    }
}