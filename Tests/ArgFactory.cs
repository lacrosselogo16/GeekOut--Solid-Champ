namespace Tests
{
	public enum ArgType
	{
		NULL
		,LANGUAGE_ONLY
		,LANGUAGE_ONLY_UPPERCASE
		,LANGUAGE_ONLY_LOWERCASE
		,LANGUAGE_ONLY_MIXEDCASE
		,FIRSTNAME_WITH_LANGUAGE
		,FULLNAME_WITH_LANGUAGE
		,FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER
	}
	public class ArgFactory:GreetingTestsBase
	{
		protected string[] With(ArgType value)
		{
			switch(value)
			{
				case ArgType.LANGUAGE_ONLY:
            		return new string[] {_languageName};
				case ArgType.LANGUAGE_ONLY_UPPERCASE:
	            	return new string[] {_languageName.ToUpper()};
				case ArgType.LANGUAGE_ONLY_LOWERCASE:
	            	return new string[] {_languageName.ToLower()};
				case ArgType.LANGUAGE_ONLY_MIXEDCASE:
	            	return new string[] {TestHelper.MixedCase(_languageName)};

	            case ArgType.FIRSTNAME_WITH_LANGUAGE:
	            	return new string[] {_userName,_languageName};
	
				case ArgType.FULLNAME_WITH_LANGUAGE:
	            	return new string[] {_fullName,_languageName};
	
				case ArgType.FIRSTNAME_LANGUAGE_AND_THIRD_PARAMETER:
	            	return new string[] {_userName,_languageName, "blah"};
				case ArgType.NULL:
	            default:
	            	return null;
			}
		}
	}
}
