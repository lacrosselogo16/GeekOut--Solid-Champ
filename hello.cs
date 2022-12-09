using HelloWorldProgram.BusinessLogic;

namespace HelloWorldProgram
{
	internal class Hello 
	{
		private static void Main(string[] args)
        {
        	var message = GreetingFactory.Create(args);
        	message.Display();
    	}
	}
}