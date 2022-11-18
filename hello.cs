using System;
namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{       
		static void Main(string[] args)
        {
        	// one parameter logic
			if(args.Length > 0)
			{
				if(args[0].ToUpper() == "FRENCH")
				{
					Console.WriteLine("Bonjour le monde!");
				}
				else if(args[0].ToUpper() == "ITALIAN")
				{
					Console.WriteLine("Ciao Mondo!");
				}
				else if(args[0].ToUpper() == "SPANISH")
				{
					Console.WriteLine("Hola Mundo!");
				}
				else if(args[0].ToUpper() == "ENGLISH" || args[0] == "")
				{
					Console.WriteLine("Hello World!");
				}
				else
				{
					Console.WriteLine(args[0]);
				}	
			}

			// two parameter logic
			if(args.Length > 1)
			{
				if(args[1].ToUpper() == "FRENCH")
				{
					Console.WriteLine("Bonjour le monde!");
				}
				else if(args[1].ToUpper() == "ITALIAN")
				{
					Console.WriteLine("Ciao Mondo!");
				}
				else if(args[1].ToUpper() == "SPANISH")
				{
					Console.WriteLine("Hola Mundo!");
				}
				else if(args[1].ToUpper() == "ENGLISH" || args[1] == "")
				{
					Console.WriteLine("Hello World!");
				}
				else if(IsNotAnyLanguage(args[0]))
				{
					Console.WriteLine("Hello World!");
				}
			}

			// Not equal to 2 ege 3 or more or 1 or none
			if(args.Length != 2)
			{
				if( args.Length == 0 ||
					(
						args.Length == 1 &&
						IsNotAnyLanguage(args[0]) 
					)
				)
				{
					Console.WriteLine("Hello World!");
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
	}
}