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
            Assert.AreEqual(_languageName, Create(ArgType.LANGUAGE_ONLY_MIXEDCASE)[0]);
        }
        [TestMethod]
        public void CreateFirstNameWithLanguageTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FIRSTNAME_WITH_LANGUAGE)[0]);
        }
        [TestMethod]
        public void CreateFullNameWithLanguageTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FULLNAME_WITH_LANGUAGE)[0]);
        }
        [TestMethod]
        public void CreateFirstNameLanguageAndThirdConditionTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER)[0]);
        }
        [TestMethod]
        public void CreateNullTest()
        {
            Assert.AreEqual(_languageName, Create(ArgType.NULL)[0]);
        }
    }
}