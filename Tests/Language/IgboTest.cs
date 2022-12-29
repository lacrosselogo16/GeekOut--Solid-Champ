using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class IgboTest:GreetingTests
    {
        public IgboTest()
        {
            this._languageName = "Igbo";
            this._greeting = "Ndewo Ụwa!";
        }
    }
}