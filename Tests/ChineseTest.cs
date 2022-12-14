using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ChineseTest:GreetingTests
    {
        public ChineseTest()
        {
            _languageName = "Chinese";
            _greeting = "你好世界";
        }
    }
}