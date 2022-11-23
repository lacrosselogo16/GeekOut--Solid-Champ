using System;
using System.Collections.Generic;
namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{
    	static Dictionary<string,string> _mapGreetings = new Dictionary<string,string>{{"ENGLISH", "Hello World!"},{"FRENCH", "Bonjour le monde!"},{"ITALIAN", "Ciao Mondo!"},{"SPANISH", "Hola Mundo!"},{"JAPANESE", "こんにちは世界"},{"CHINESE", "你好世界"}};
    	static string _name = "";
    	static string _greeting = _mapGreetings["ENGLISH"];
    	

		static void Main(string[] args)
        {
        	Intialize(args);	
        	DisplayGreeting();
    	}

    	static void Intialize(string[] args)
    	{
    		if(args.Length > 0)
    		{
    			if(IsAMappedLanguage(args[0]))
    			{

    			}
    			else
    			{
    				_name = args[0];
    				if(args.Length > 1 && IsAMappedLanguage(args[1]))
    				{

    				}
    			}
    		}
    	}

    	static void DisplayGreeting()
    	{
    		Console.WriteLine(_name);
    		Console.WriteLine(_greeting);
    	}

		static bool IsAMappedLanguage(string language)
    	{
    		try
    		{
    			_greeting = _mapGreetings[language.ToUpper()];
    			return true;
    		}
    		catch
    		{
    			return false;
    		}
    	}
	}
}