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
        public GermanTest(string language)
        {
            this._languageName = "German";
            this._greeting = "Hallo Welt!";
        }
    }
}
var language = new GermanTest();
var language2 = new GermanTest("Ich bin ein auslander");