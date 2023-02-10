using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Enums.Arguments;

namespace Tests
{
    public class House
    {
        private string _address;
        public int _window;
        public int _door;

        public string Address
        {
            get
            {
                return _address.ToUpper();
            }
        }

        public House(string address)
        {
            this._address = address;
        }  
    }
    [TestClass]
    public class HouseTest
    {
        [TestMethod]
        public void HouseCall()
        {
            //Arrange
            var a = 10;
            var b = "10";
            House house = new House("100 S 200 E, Salt Lake City, UT 84111");
            var houseTwo = new House("100 W 200 N, Pleasant Grove, UT 84062");
            //Act
            // house.Address = "100 S 200 E, Salt Lake City, UT 84111";
            // house._address = "100 S 200 E, Salt Lake City, UT 84111";
            house._window = 2;
            house._door = 8;
            // houseTwo.Address = "100 W 200 N, Pleasant Grove, UT 84062";
            houseTwo._window = 5;
            houseTwo._door = 2;

            // house.Address = "hello world";
            var expectedOne = "100 S 200 E, SALT LAKE CITY, UT 84111";
            var expectedTwo = "100 W 200 N, PLEASANT GROVE, UT 84062";
            //Assert
            Assert.AreEqual(expectedOne, house.Address);
            Assert.AreEqual(expectedTwo, houseTwo.Address);

            Assert.AreEqual(expectedOne, house.Address);
            Assert.AreEqual(2, house._window);
            Assert.AreEqual(8, house._door);
            Assert.AreEqual(expectedTwo, houseTwo.Address);
            Assert.AreEqual(5, houseTwo._window);
            Assert.AreEqual(2, houseTwo._door);
            Assert.IsNotNull(house, "Oopsie!");
            // Assert.Fail("made to the end.");
        }
    }

    public class Blah
    {
        private int _someInt = 10;
        private string _someString = "Uncle Rocks!";
        public int SomeInt
        {
            // int get()
            get
            {
                return _someInt + 10;
            }
            // set(int value)
            set
            {
                _someInt = value * 2;
            }
        }
        public Blah AnotherBlah{get;set;}
        public Blah MySelf{get{return this;}}
        public string SomeString
        {
            // string get()
            get
            {
                return _someString;
            }
            // set(string value)
            set
            {
                _someString = value;
            }
        }

        public string ThisSucksToo()
        {
            var sb = new StringBuilder("This sucks too: ");
            sb.Append(_someString);
            return sb.ToString();
        }
    }
    [TestClass]
    public class ThisSucksTooClassTests
    {
        [TestMethod]
        public void TestOne()
        {
            //Arrange
            //Act
            //Assert
            Assert.Fail();
        }
        [TestMethod]
        public void TestTwo()
        {
            Assert.Fail();
        }
        [TestMethod]
        public void TestThree()
        {
            Assert.Fail();
        }
        
    }
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
        //FullName and language Test
        [TestMethod]
        public void PassFullNameAndLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_LANGUAGE), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameAndUpperCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_UPPERCASELANGUAGE), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameAndLowerCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_LOWERCASELANGUAGE), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameAndMixedCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.FULLNAME_WITH_MIXEDCASELANGUAGE), ExpectedGreetingWith(true));
        }
        //Swap FullName and language Test
        [TestMethod]
        public void SwapPassFullNameAndLanguageNameTest()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_WITH_LANGUAGE), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameAndUpperCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_WITH_UPPERCASELANGUAGE), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameAndLowerCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_WITH_LOWERCASELANGUAGE), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameAndMixedCaseLanguageNameTest()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_WITH_MIXEDCASELANGUAGE), _greeting);
        }
        //FullName with third Parameter
        [TestMethod]
        public void PassFullNameLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FULLNAME_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameUpperCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameLowerCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith(true));
        }
        [TestMethod]
        public void PassFullNameMixedCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER), ExpectedGreetingWith(true));
        }
        //Swap FullName with third Parameter
        [TestMethod]
        public void SwapPassFullNameLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameUpperCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameLowerCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
        [TestMethod]
        public void SwapPassFullNameMixedCaseLanguageAndThirdParameter()
        {
            TestGreeting(With(ArgType.SWAP_FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER), _greeting);
        }
    }
}