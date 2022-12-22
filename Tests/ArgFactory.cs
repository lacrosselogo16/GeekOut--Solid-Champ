namespace Tests
{
	public enum ArgType
	{
		LANGUAGE_ONLY
		,LANGUAGE_ONLY_UPPERCASE
	}
	public class ArgFactory:GreetingTestsBase
	{
		protected string[] Create(ArgType value)
		{
			string[] result;
			switch(value)
			{
				case ArgType.LANGUAGE_ONLY:
            		result = new string[] {_languageName};
					break;
				case ArgType.LANGUAGE_ONLY_UPPERCASE:
	            	result = new string[] {_languageName.ToUpper()};
					break;
				default:
	            	result = new string[] {_languageName.ToLower()};
	            	result = new string[] {_userName,_languageName};
	            	result = new string[] {_fullName,_languageName};
	            	result = new string[] {_userName,_languageName, "blah"};
	            	result = new string[] {TestHelper.MixedCase(_languageName)};
					break;
			}

			return result;
		}
	}
}
