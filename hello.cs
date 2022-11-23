using System;
using System.Collections.Generic;
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
    	
    	static Dictionary<string,string> _mapGreetings; 
    	// = new Dictionary<string,string>{
    	// 	{"ENGLISH", "Hello World!"}
    	// 	,{"FRENCH", "Bonjour le monde!"}
    	// 	,{"ITALIAN", "Ciao Mondo!"}
    	// 	,{"SPANISH", "Hola Mundo!"}
    	// 	,{"JAPANESE", "こんにちは世界"}
    	// 	,{"CHINESE", "你好世界"}
    	// };

		static void Main(string[] args)
        {
        	_mapGreetings= new Dictionary<string,string>();
        	_mapGreetings.Add("ENGLISH", "Hello World!");
        	_mapGreetings.Add("ENGLISH", "BLAH!!!");
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

    	// static void DisplayLanguages()
    	// {
    	// 	for(int index = 0; index < _languages.Length; index++)
    	// 	{
    	// 		Console.Write(_languages[index]);
    	// 		Console.Write(" ");
    	// 		Console.WriteLine(_greetings[index]);
    	// 	}
    	// }

    	static void DisplayLanguageGreeting(string language)
    	{
    		try
    		{
    			Console.WriteLine(_mapGreetings[language.ToUpper()]);
    		}
    		catch
    		{
    			Console.WriteLine(_mapGreetings["ENGLISH"]);
    		}
    	}

    	static bool ShouldDisplayDefaultGreeting(string[] args)
    	{
    		return (args.Length != 2 && ( args.Length == 0 || ( args.Length == 1 && IsNotAnyLanguage(args[0]))));
    	}

    	//check if string is NOT a mapped language.
		static bool IsNotAnyLanguage(string language)
    	{
    		try
    		{
    			var message = _mapGreetings[language.ToUpper()];
    			return false;
    		}
    		catch
    		{
    			return true;
    		}
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