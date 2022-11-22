using System;
namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{
		static string value1 = "";
    	static string value2 = "";

		static void Main(string[] args)
        {
        	

        	Intialize(args);	

        	// one parameter logic
			DisplayGreetingByLanguage(value1);

			// two parameter logic
			if(IsNotAnyLanguage(value1))
			{
				DisplayGreetingByLanguage(value2);
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
    	static bool ShouldDisplayDefaultGreeting(string[] args)
    	{
    		return (args.Length != 2 && ( args.Length == 0 || ( args.Length == 1 && IsNotAnyLanguage(args[0]))));
    	}

    	static void DisplayGreetingByLanguage(string language)
    	{
    		language = language.ToUpper();
    		if(language == "FRENCH")
			{
				Console.WriteLine("Bonjour le monde!");
			}
			else if(language == "ITALIAN")
			{
				Console.WriteLine("Ciao Mondo!");
			}
			else if(language == "SPANISH")
			{
				Console.WriteLine("Hola Mundo!");
			}
			else if(language == "ENGLISH")
			{
				DisplayEnglishGreeting();
			}
			else if(language == "JAPANESE")
			{
				Console.WriteLine("こんにちは世界");
			}
    	}

		static bool IsNotAnyLanguage(string language)
    	{
    		language = language.ToUpper();

    		return (
				language != "ENGLISH" 
				&& language != "FRENCH" 
				&& language != "ITALIAN"
				&& language != "SPANISH"
				&& language != "JAPANESE"
    		);

    		// return !(
			// 	language.ToUpper() == "ENGLISH" 
			// 	|| language.ToUpper() == "FRENCH" 
			// 	|| language.ToUpper() == "ITALIAN"
			// 	|| language.ToUpper() == "SPANISH"
    		// );
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