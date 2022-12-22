using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests:ArgFactory
    {
        [TestMethod]
        public void PassLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY));
        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY_UPPERCASE));
        }

        [TestMethod]
        public void PassLowercaseLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY_LOWERCASE));
        }

        [TestMethod]
        public void PassUserNameAndLanguageNameTest()
        {
            TestGreeting(Create(ArgType.FIRSTNAME_WITH_LANGUAGE), ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassFullUserNameAndLanguageNameTest()
        {
            TestGreeting(Create(ArgType.FULLNAME_WITH_LANGUAGE), ExpectedGreetingWith(true));
        }

        [TestMethod]
        public void PassThreeArgumentsTest()
        {
            TestGreeting(Create(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassMixedCaseLanguageNameTest()
        {
            TestGreeting(Create(ArgType.LANGUAGE_ONLY_MIXEDCASE));
        }
    }
}