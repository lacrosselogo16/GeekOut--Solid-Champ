using Tests.Enums.Arguments;
using System.Collections.Generic;

namespace Tests
{
	public class ArgFactory:GreetingTestsBase
	{
		private List<string> _data;

		public string[] Data
		{
			get
			{
				return _data.ToArray();
			}
		}

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
			_data = new List<string>();
			switch(argType)
			{
				case ArgType.NULL:
	            	return null;
			}

			switch(languageCase)
			{
				case LanguageCase.UPPER:
					_data.Add(_languageName.ToUpper());
					break;
				case LanguageCase.LOWER:
					_data.Add(_languageName.ToLower());
					break;
				case LanguageCase.MIXED:
					_data.Add(TestHelper.MixedCase(_languageName));
					break;
				case LanguageCase.NORMAL:
				default:
					_data.Add(_languageName);
					break;
			}

			switch(name)
			{
				case Name.NONAME:
					return null;
				case Name.FIRSTNAME:
					_data.Add(_userName);
					break;
				case Name.FULLNAME:
					_data.Add(_fullName);
					break;
			}

			switch(thirdParameter)
			{
				case ThirdParameter.YES:
					_data.Add("blah");
					break;
			}

			switch(swapNameWithLanguage)
			{
				case SwapNameWithLanguage.YES:
					if(_data.Count > 1)
					{
						var temp = _data[0];
						_data[0] = _data[1];
						_data[1] = temp;
					}
					break;
			}
			return Data;
		}
	}
}
