using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UkrainianTest:GreetingTests
    {
        public UkrainianTest()
        {
            this._languageName = "Ukrainian";
            this._greeting = "Привіт Світ!";
        }
    }
}