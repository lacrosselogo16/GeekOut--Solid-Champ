using HelloWorldProgram.BusinessLogic.Interfaces;

namespace HelloWorldProgram.BusinessLogic
{
	public class GreetingFactory
	{
		public static IDisplayable Create(string[] data)
		{
			if(data != null && data.Length > 0 && data[0].ToLower() == "help")
        	{
        		return new HelpMenu(data);
        	}
        	else
        	{
	        	return new Greeting(data);
        	}
		}
	}
}