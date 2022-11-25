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
        	DetermineGreeting(args);	
        	DetermineName(args);	
        	DisplayGreeting();
    	}

    	static void DetermineGreeting(string[] args)
    	{ 
    		_greeting = IsValidGreeting(args, 0)?_mapGreetings[args[0].ToUpper()]
    		:IsValidGreeting(args, 1)?_mapGreetings[args[1].ToUpper()]
    		:_greeting;
    	}

    	static bool IsValidGreeting(string[] args, int index)
    	{
    		return (args.Length > index && IsAMappedLanguage(args[index]));
    	}

		static void DetermineName(string[] args)
    	{
    		_name = IsNameAvailable(args)? args[0]:"";
    	}

    	static bool IsNameAvailable(string[] args)
    	{
    		return args.Length > 0 && !IsAMappedLanguage(args[0]);
    	}

    	static void DisplayGreeting()
    	{
    		if(_name != "")
    		{
    			Console.WriteLine(_name);
    		}
    		Console.WriteLine(_greeting);
    	}

		static bool IsAMappedLanguage(string language)
    	{
    		try
    		{
    			var a = _mapGreetings[language.ToUpper()];
    			return true;
    		}
    		catch
    		{
    			return false;
    		}
    	}
	}
}