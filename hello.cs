using System;
namespace blah
{

	class Hello 
	{         
		static void Main(string[] args)
        	{
			Console.Clear();
			
			if(args.Length > 0)
			{
				Console.WriteLine(args[0]);
			}
			
			Console.WriteLine("Hello World!");
			Console.Beep();
        	}
	}
}