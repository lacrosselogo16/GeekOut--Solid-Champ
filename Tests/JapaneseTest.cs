using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class JapaneseTest:GreetingTests
    {
        public JapaneseTest()
        {
            _languageName = "Japanese";
            _greeting = "こんにちは世界";
        }
    }
}