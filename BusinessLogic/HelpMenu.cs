using System;
using HelloWorldProgram.BusinessLogic.Interfaces;

namespace HelloWorldProgram.BusinessLogic
{
	internal class HelpMenu:IDisplayable
	{
		private string[] _data;

		public HelpMenu(string[] data)
		{
			_data = data;
		}
		
		public void Display()
		{
	        Console.WriteLine("Input <Name> <Language>\n");
    		Console.WriteLine("Example:");
    		Console.WriteLine("\tHello");
    		Console.WriteLine("\tHello Tiffany");
    		Console.WriteLine("\tHello Tiffany French");
    		Console.WriteLine("\tHello French");
    		Console.WriteLine("\tHello help\n");
    		Console.WriteLine("Listed Active Languages:");
    		var a = new Greeting(_data);
    		foreach(var greeting in a.Greetings)
    		{
    			Console.WriteLine("\t{0}", greeting.Key);
    		}
		}
	}
}