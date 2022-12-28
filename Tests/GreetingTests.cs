using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public abstract class GreetingTests:ArgFactory
    {
        private string _ExpectedToFail = "Turd";
        //Language Only
        [TestMethod]
        public void PassLanguageNameTest()
        {
            TestGreeting(With(ArgType.LANGUAGE_ONLY));
        }

        [TestMethod]
        public void PassUppercaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.LANGUAGE_ONLY_UPPERCASE));
        }

        [TestMethod]
        public void PassLowercaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.LANGUAGE_ONLY_LOWERCASE));
        }

        [TestMethod]
        public void PassMixedCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.LANGUAGE_ONLY_MIXEDCASE));
        }
        //First Name and Language
        [TestMethod]
        public void PassUserNameAndLanguageNameTest()
        {
            TestGreeting(With(ArgType.FIRSTNAME_WITH_LANGUAGE), ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassUserNameAndUpperCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FIRSTNAME_WITH_UPPERCASELANGUAGE), ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassUserNameAndLowerCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FIRSTNAME_WITH_LOWERCASELANGUAGE), ExpectedGreetingWith());
        }

        [TestMethod]
        public void PassUserNameAndMixedCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FIRSTNAME_WITH_MIXEDCASELANGUAGE), ExpectedGreetingWith());
        }
        //Swap First Name and Language
        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_LANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_LANGUAGE), _ExpectedToFail);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE), _ExpectedToFail);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE), _ExpectedToFail);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE), _ExpectedToFail);
        }
        //FirstName with third Parameter

        [TestMethod]
        public void PassFullUserNameAndLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_LANGUAGE), ExpectedGreetingWith(true));
        }

        [TestMethod]
        public void PassThreeArgumentsTest()
        {
            TestGreeting(With(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }

    }
}