using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MixedCaseTests
    {
        [TestMethod]
        public void TestMixCaseNameTest()
        {
            //Arrange
            var expected = "AbCdEfG";
            var value = "abcdefg";
            //Act
            var actual = TestHelper.MixedCase(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMixCaseNameTest2()
        {
            //Arrange
            var expected = "AbCdEfG";
            var value = "Abcdefg";
            //Act
            var actual = TestHelper.MixedCase(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMixCaseNameTest3()
        {
            //Arrange
            var expected = "aBcDeFg";
            var value = "Abcdefg";
            //Act
            var actual = TestHelper.MixedCase(value, false);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}