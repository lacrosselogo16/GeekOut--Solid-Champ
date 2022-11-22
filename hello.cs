using System;
namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{
		static string value1 = "";
    	static string value2 = "";
    	// static string _name = "";
    	// static string _language = "";
    	// static string _greeting = "";
    	static readonly string[] _languages = {"ENGLISH", "FRENCH", "ITALIAN", "SPANISH", "JAPANESE", "CHINESE"};
    	static readonly string[] _greetings = {"Hello World!", "Bonjour le monde!", "Ciao Mondo!", "Hola Mundo!", "こんにちは世界", "你好世界"};

		static void Main(string[] args)
        {
        	Intialize(args);	

        	// one parameter logic
			DisplayLanguageGreeting(value1);

			// two parameter logic
			if(IsNotAnyLanguage(value1))
			{
				DisplayLanguageGreeting(value2);
			}

			// Not equal to 2 ege 3 or more or 1 or none
			if(ShouldDisplayDefaultGreeting(args))
			{
				DisplayDefaultGreeting();
			}
    	}

    	static void Intialize(string[] args)
    	{
    		
        	if(args.Length > 0)
        	{
        		value1 = args[0];
        		if(args.Length > 1)
        		{
        			value2 = args[1];
        		}
        	}
        	DisplayInitialGreeting(value1, value2);
    	}

    	static void DisplayLanguages()
    	{
    		for(int index = 0; index < _languages.Length; index++)
    		{
    			Console.Write(_languages[index]);
    			Console.Write(" ");
    			Console.WriteLine(_greetings[index]);
    		}
    	}

    	static void DisplayLanguageGreeting(string language)
    	{
    		for(int index = 0; index < _languages.Length; index++)
    		{
    			if(language.ToUpper() == _languages[index])
				{
					Console.WriteLine(_greetings[index]);
				}
    		}	
    	}

    	static bool ShouldDisplayDefaultGreeting(string[] args)
    	{
    		return (args.Length != 2 && ( args.Length == 0 || ( args.Length == 1 && IsNotAnyLanguage(args[0]))));
    	}

		static bool IsNotAnyLanguage(string language)
    	{
    		language = language.ToUpper();
    		for(int index = 0; index < _languages.Length; index++)
    		{
    			if(language == _languages[index])
				{
					return false;
				}
    		}
			return true;
    	}

    	static void DisplayInitialGreeting(string val1, string val2)
    	{
    		if(IsNotAnyLanguage(val1))
        	{
	        	if(val1 != "")
	        	{
	        		Console.WriteLine(val1);
	        	}
	        	if(val2 != "" && IsNotAnyLanguage(val2))
	        	{
	        		DisplayDefaultGreeting();	
	        	}
        	}
    	}

    	static void DisplayDefaultGreeting()
    	{
			DisplayEnglishGreeting();
    	}

    	static void DisplayEnglishGreeting()
    	{
			Console.WriteLine("Hello World!");
    	}
	}
}