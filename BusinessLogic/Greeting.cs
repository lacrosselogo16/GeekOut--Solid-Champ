using System.Collections.Generic;

namespace HelloWorldProgram.BusinessLogic
{
	internal class Greeting:AbstractDisplay
	{
		private static Dictionary<string,string> _mapGreetings = new Dictionary<string,string>{
			{"ENGLISH", "Hello World!"}
			,{"FRENCH", "Bonjour le monde!"}
			,{"ITALIAN", "Ciao Mondo!"}
			,{"SPANISH", "Hola Mundo!"}
			,{"JAPANESE", "こんにちは世界"}
			,{"CHINESE", "你好世界"}
			,{"GERMAN", "Hallo Welt!"}
			,{"UKRAINIAN", "Привіт Світ!"}
			,{"POLISH", "Witaj świecie!"}
		};

    	private string _name = "";
    	private string _greeting = _mapGreetings["ENGLISH"];

    	public Dictionary<string,string> Greetings 
    	{
    		get
    		{
    			return _mapGreetings;
    		}
    	}
    	public Greeting(string[] args)
    	{
    		DetermineGreeting(args);	
        	DetermineName(args);
    	}

    	private void DetermineGreeting(string[] stuff)
    	{ 
    		_greeting = IsValidGreeting(stuff, 0)?_mapGreetings[stuff[0].ToUpper()]
    		:IsValidGreeting(stuff, 1)?_mapGreetings[stuff[1].ToUpper()]
    		:_greeting;
    	}

    	private bool IsValidGreeting(string[] args, int index)
    	{
    		return (args.Length > index && IsAMappedLanguage(args[index]));
    	}

		private void DetermineName(string[] args)
    	{
    		_name = IsNameAvailable(args)? args[0]:"";
    	}

    	private bool IsNameAvailable(string[] args)
    	{
    		return args.Length > 0 && !IsAMappedLanguage(args[0]);
    	}

    	public override string Display()
    	{
    		if(string.IsNullOrEmpty(_name))
    		{
    			_result.Append(_greeting);
    		}
    		else
    		{
    			_result.Append(_greeting.Split(' ')[0]);
    			_result.Append(" ");
    			_result.Append(_name);
    		}
    		return base.Display();
    	}

		private bool IsAMappedLanguage(string language)
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