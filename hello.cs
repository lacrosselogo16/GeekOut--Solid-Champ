//to compile: csc .\hello.cs, .\Greeting.cs
using System;

namespace blah
{
	// Returns Name if specified and Hello World in many different language that you specify.
	class Hello 
	{
		static void Main(string[] args)
        {

        	if(args != null && args.Length > 0 && args[0].ToLower() == "help")
        	{
        		Console.WriteLine("Input <Name> <Language>\n");
        		Console.WriteLine("Example:");
        		Console.WriteLine("\tHello");
        		Console.WriteLine("\tHello Tiffany");
        		Console.WriteLine("\tHello Tiffany French");
        		Console.WriteLine("\tHello French");
        		Console.WriteLine("\tHello help\n");
        		Console.WriteLine("Listed Active Languages:");
        		var a = new Greeting(args);
        		foreach(var greeting in a.Greetings)
        		{
        			Console.WriteLine("\t{0}", greeting.Key);
        		}

        	}
        	else
        	{
	        	Greeting myInstance;
	        	myInstance = new Greeting(args);
	        	myInstance.DisplayGreeting();

        	}
    	}
	}
}