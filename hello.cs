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
			Console.Clear();
			
			if(args.Length > 0)
				Console.WriteLine(args[0]);
			//Console.WriteLine(args[1].ToUpper());
			//Console.WriteLine(args[1]);
			if(args.Length > 1 && args[1].ToUpper() == "FRENCH")
				Console.WriteLine("Bonjour le monde!");
			else
				Console.WriteLine("Hello World!");

			Console.Beep();
        	}
	}
}