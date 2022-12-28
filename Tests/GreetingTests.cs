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
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_LANGUAGE), _greeting);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE), _greeting);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE), _greeting);
        }

        [TestMethod]
        public void SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE), _greeting);
        }
        //FirstName with third Parameter
        [TestMethod]
        public void PassFirstNameLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }
        [TestMethod]
        public void PassFirstNameUpperCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }
        [TestMethod]
        public void PassFirstNameLowerCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }
        [TestMethod]
        public void PassFirstNameMixedCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith());
        }
        //Swap FirstName with third Parameter
        [TestMethod]
        public void SwapPassFirstNameLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFirstNameUpperCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFirstNameLowerCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFirstNameMixedCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        //
        [TestMethod]
        public void PassFullUserNameAndLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_LANGUAGE), ExpectedGreetingWith(true));
        }


    }
}