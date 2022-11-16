using System;
namespace blah
{
	class Hello 
	{       
		/*
			want to test four conditions: no parameters, single parameter name, pass in string with spaces, languages none and french, 
			defaults to english if unknown second parameter with name.

			Example: hello Gregory French
		*/  
		static void Main(string[] args)
        {
        	
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
				else if(args[0].ToUpper() == "ENGLISH" || args[0] == "")
				{
					Console.WriteLine("Hello World!");
				}
				else
				{
					Console.WriteLine(args[0]);
				}	
			}

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
				else if(args[1].ToUpper() == "ENGLISH" || args[1] == "")
				{
					Console.WriteLine("Hello World!");
				}

			}

			if(args.Length < 2)
			{
				if( args.Length == 0 || 
					(
						args.Length == 1 
						&& args[0].ToUpper() != "ENGLISH" 
						&& args[0].ToUpper() != "FRENCH" 
						&& args[0].ToUpper() != "ITALIAN"
					)
				)
				{
					Console.WriteLine("Hello World!");
				}
			}
    	}
	}
}