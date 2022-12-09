using System;
using HelloWorldProgram.BusinessLogic;

namespace HelloWorldProgram
{
	internal class Hello 
	{
		private static void Main(string[] args)
        {
        	Console.WriteLine(GreetingFactory.Create(args).Display());
    	}
	}
}