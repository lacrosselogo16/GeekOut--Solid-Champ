using System;
namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{       
		static void Main(string[] args)
        {
        	string value1 = "";
        	string upperValue1 = "";
        	string value2 = "";
        	string upperValue2 = "";

        	if(args.Length > 0)
        	{
        		value1 = args[0];
        		upperValue1 = value1.ToUpper();
        		if(args.Length > 1)
        		{
        			value2 = args[1];
        			upperValue2 = value2.ToUpper();
        		}
        	}
        	DisplayInitialGreeting(value1, value2);

        	// one parameter logic
			if(upperValue1 == "FRENCH")
			{
				Console.WriteLine("Bonjour le monde!");
			}
			else if(upperValue1 == "ITALIAN")
			{
				Console.WriteLine("Ciao Mondo!");
			}
			else if(upperValue1 == "SPANISH")
			{
				Console.WriteLine("Hola Mundo!");
			}
			else if(upperValue1 == "ENGLISH")
			{
				DisplayEnglishGreeting();
			}

			// two parameter logic
			if(IsNotAnyLanguage(value1))
			{
				if(upperValue2 == "FRENCH")
				{
					Console.WriteLine("Bonjour le monde!");
				}
				else if(upperValue2 == "ITALIAN")
				{
					Console.WriteLine("Ciao Mondo!");
				}
				else if(upperValue2 == "SPANISH")
				{
					Console.WriteLine("Hola Mundo!");
				}
				else if(upperValue2 == "ENGLISH")
				{
					DisplayEnglishGreeting();
				}
			}

			// Not equal to 2 ege 3 or more or 1 or none
			if(args.Length != 2)
			{
				if( args.Length == 0 ||
					(
						args.Length == 1 &&
						IsNotAnyLanguage(value1) 
					)
				)
				{
					DisplayDefaultGreeting();
				}
			}
    	}

		static bool IsNotAnyLanguage(string language)
    	{
    		return (
				language.ToUpper() != "ENGLISH" 
				&& language.ToUpper() != "FRENCH" 
				&& language.ToUpper() != "ITALIAN"
				&& language.ToUpper() != "SPANISH"
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