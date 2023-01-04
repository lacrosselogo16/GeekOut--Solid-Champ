namespace Tests
{
	public class ArgFactory:GreetingTestsBase
	{
		protected string[] With(ArgType argType)
		{
			switch(argType)
			{
				//Language Only
				case ArgType.LANGUAGE_ONLY:
            		return new string[] {_languageName};
				case ArgType.LANGUAGE_ONLY_UPPERCASE:
	            	return new string[] {_languageName.ToUpper()};
				case ArgType.LANGUAGE_ONLY_LOWERCASE:
	            	return new string[] {_languageName.ToLower()};
				case ArgType.LANGUAGE_ONLY_MIXEDCASE:
	            	return new string[] {TestHelper.MixedCase(_languageName)};
	            //First Name Regular
	            case ArgType.FIRSTNAME_WITH_LANGUAGE:
	            	return new string[] {_userName,_languageName};
	            case ArgType.FIRSTNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_userName,_languageName.ToUpper()};
	            case ArgType.FIRSTNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_userName,_languageName.ToLower()};
	            case ArgType.FIRSTNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {_userName,TestHelper.MixedCase(_languageName)};
				//Swap FIRSTNAME
	            case ArgType.SWAP_FIRSTNAME_WITH_LANGUAGE:
	            	return new string[] {_languageName, _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_languageName.ToUpper(), _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_languageName.ToLower(), _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {TestHelper.MixedCase(_languageName), _userName};
	            //FIRSTNAME with third parameter
				case ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName, "blah"};
	            case ArgType.FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName.ToUpper(), "blah"};
	            case ArgType.FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName.ToLower(), "blah"};
	            case ArgType.FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,TestHelper.MixedCase(_languageName), "blah"};
	            //SWAP FIRSTNAME with third parameter
				case ArgType.SWAP_FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName,_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToUpper(),_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToLower(),_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {TestHelper.MixedCase(_languageName),_userName, "blah"};
	            

	            //FULLNAME Regular
	            case ArgType.FULLNAME_WITH_LANGUAGE:
	            	return new string[] {_fullName,_languageName};
	            case ArgType.FULLNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_fullName,_languageName.ToUpper()};
	            case ArgType.FULLNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_fullName,_languageName.ToLower()};
	            case ArgType.FULLNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {_fullName,TestHelper.MixedCase(_languageName)};
				//Swap FULLNAME
	            case ArgType.SWAP_FULLNAME_WITH_LANGUAGE:
	            	return new string[] {_languageName, _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_languageName.ToUpper(), _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_languageName.ToLower(), _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {TestHelper.MixedCase(_languageName), _fullName};
	            //FULLNAME with third parameter
				case ArgType.FULLNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName, "blah"};
	            case ArgType.FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName.ToUpper(), "blah"};
	            case ArgType.FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName.ToLower(), "blah"};
	            case ArgType.FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,TestHelper.MixedCase(_languageName), "blah"};
	            //SWAP FULLNAME with third parameter
				case ArgType.SWAP_FULLNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName,_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToUpper(),_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToLower(),_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {TestHelper.MixedCase(_languageName),_fullName, "blah"};

	            case ArgType.NOTNULL:
				case ArgType.EMPTY:
	            	return new string[]{};
				case ArgType.NULL:
	            default:
	            	return null;
			}
		}
		protected string[] With(SwapNameWithLanguage swapNameWithLanguage, ThirdParameter thirdParameter, Name name, LanguageCase languageCase=LanguageCase.NORMAL, ArgType argType=ArgType.NOTNULL)
		{
			switch(argType)
			{
				case ArgType.NOTNULL:
					break;
				case ArgType.EMPTY:
	            	return new string[]{};
				case ArgType.NULL:
	            default:
	            	return null;
			}

			switch(languageCase)
			{
				case LanguageCase.UPPER:
					return new string[] {_languageName.ToUpper()};
				case LanguageCase.LOWER:
					return new string[] {_languageName.ToLower()};
				case LanguageCase.MIXED:
					return new string[] {TestHelper.MixedCase(_languageName)};
				case LanguageCase.NORMAL:
				default:
					return new string[] {_languageName};
			}

			switch(name)
			{
				case Name.NONAME:
					return null;
				case Name.FIRSTNAME:
					return new string[] {_userName};
				case Name.FULLNAME:
					return new string[] {_fullName};
			}

			switch(thirdParameter)
			{
				case ThirdParameter.YES:
					break;
				case ThirdParameter.NO:
					break;
			}

			switch(swapNameWithLanguage)
			{
				case SwapNameWithLanguage.YES:
					break;
				case SwapNameWithLanguage.NO:
					break;
			}

			switch(argType)
			{
				//Language Only
				case ArgType.LANGUAGE_ONLY:
            		return new string[] {_languageName};
				case ArgType.LANGUAGE_ONLY_UPPERCASE:
	            	return new string[] {_languageName.ToUpper()};
				case ArgType.LANGUAGE_ONLY_LOWERCASE:
	            	return new string[] {_languageName.ToLower()};
				case ArgType.LANGUAGE_ONLY_MIXEDCASE:
	            	return new string[] {TestHelper.MixedCase(_languageName)};
	            //First Name Regular
	            case ArgType.FIRSTNAME_WITH_LANGUAGE:
	            	return new string[] {_userName,_languageName};
	            case ArgType.FIRSTNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_userName,_languageName.ToUpper()};
	            case ArgType.FIRSTNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_userName,_languageName.ToLower()};
	            case ArgType.FIRSTNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {_userName,TestHelper.MixedCase(_languageName)};
				//Swap FIRSTNAME
	            case ArgType.SWAP_FIRSTNAME_WITH_LANGUAGE:
	            	return new string[] {_languageName, _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_languageName.ToUpper(), _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_languageName.ToLower(), _userName};
	            case ArgType.SWAP_FIRSTNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {TestHelper.MixedCase(_languageName), _userName};
	            //FIRSTNAME with third parameter
				case ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName, "blah"};
	            case ArgType.FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName.ToUpper(), "blah"};
	            case ArgType.FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName.ToLower(), "blah"};
	            case ArgType.FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,TestHelper.MixedCase(_languageName), "blah"};
	            //SWAP FIRSTNAME with third parameter
				case ArgType.SWAP_FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName,_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToUpper(),_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToLower(),_userName, "blah"};
	            case ArgType.SWAP_FIRSTNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {TestHelper.MixedCase(_languageName),_userName, "blah"};
	            

	            //FULLNAME Regular
	            case ArgType.FULLNAME_WITH_LANGUAGE:
	            	return new string[] {_fullName,_languageName};
	            case ArgType.FULLNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_fullName,_languageName.ToUpper()};
	            case ArgType.FULLNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_fullName,_languageName.ToLower()};
	            case ArgType.FULLNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {_fullName,TestHelper.MixedCase(_languageName)};
				//Swap FULLNAME
	            case ArgType.SWAP_FULLNAME_WITH_LANGUAGE:
	            	return new string[] {_languageName, _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_UPPERCASELANGUAGE:
	            	return new string[] {_languageName.ToUpper(), _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_LOWERCASELANGUAGE:
	            	return new string[] {_languageName.ToLower(), _fullName};
	            case ArgType.SWAP_FULLNAME_WITH_MIXEDCASELANGUAGE:
	            	return new string[] {TestHelper.MixedCase(_languageName), _fullName};
	            //FULLNAME with third parameter
				case ArgType.FULLNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName, "blah"};
	            case ArgType.FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName.ToUpper(), "blah"};
	            case ArgType.FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,_languageName.ToLower(), "blah"};
	            case ArgType.FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_fullName,TestHelper.MixedCase(_languageName), "blah"};
	            //SWAP FULLNAME with third parameter
				case ArgType.SWAP_FULLNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName,_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_UPPER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToUpper(),_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_LOWER_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_languageName.ToLower(),_fullName, "blah"};
	            case ArgType.SWAP_FULLNAME_MIXED_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {TestHelper.MixedCase(_languageName),_fullName, "blah"};

	            
			}
		}
	}
}
