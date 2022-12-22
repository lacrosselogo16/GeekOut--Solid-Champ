using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CreateArgsTests:ArgFactory
    {
        [TestMethod]
        public void CreateLanguageOnlyTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.LANGUAGE_ONLY)[0]);
        }

        [TestMethod]
        public void CreateLanguageOnlyWithUpperCaseTest()
        {
            Assert.AreEqual(_languageName.ToUpper(), Create(ArgType.LANGUAGE_ONLY_UPPERCASE)[0]);
        }
        [TestMethod]
        public void CreateLanguageOnlyWithLowerCaseTest()
        {
            Assert.AreEqual(_languageName.ToLower(), Create(ArgType.LANGUAGE_ONLY_LOWERCASE)[0]);
        }
        [TestMethod]
        public void CreateLanguageOnlyWithMixedCaseTest()
        {
            var expected = new string[] {TestHelper.MixedCase(_languageName)};
            var actual = Create(ArgType.LANGUAGE_ONLY_MIXEDCASE);
            Assert.AreEqual(expected[0], actual[0]);
        }
        [TestMethod]
        public void CreateFirstNameWithLanguageTest()
        {
            var expected = new string[] {_userName,_languageName};
            var actual = Create(ArgType.FIRSTNAME_WITH_LANGUAGE);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
        [TestMethod]
        public void CreateFullNameWithLanguageTest()
        {
            var expected = new string[] {_fullName,_languageName};
            var actual = Create(ArgType.FULLNAME_WITH_LANGUAGE);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }
        [TestMethod]
        public void CreateFirstNameLanguageAndThirdConditionTest()
        {
            var expected = new string[] {_userName,_languageName, "blah"};
            var actual = Create(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);

        }
        [TestMethod]
        public void CreateNullTest()
        {
            Assert.IsNull(Create(ArgType.NULL));
        }
    }
}