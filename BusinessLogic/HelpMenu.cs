namespace HelloWorldProgram.BusinessLogic
{
	internal class HelpMenu:AbstractDisplay
	{
		private string[] _data;

		public HelpMenu(string[] data)
		{
			_data = data;
		}
		
		public override string Display()
		{
	        _result.AppendLine("Input <Name> <Language>\n");
    		_result.AppendLine("Example:");
    		_result.AppendLine("\tHello");
    		_result.AppendLine("\tHello Tiffany");
    		_result.AppendLine("\tHello Tiffany French");
    		_result.AppendLine("\tHello French");
    		_result.AppendLine("\tHello help\n");
    		_result.AppendLine("Listed Active Languages:");
    		var a = new Greeting(_data);
    		foreach(var greeting in a.Greetings)
    		{
    			_result.AppendLine("\t"+greeting.Key);
    		}
    		return _result.ToString();
		}
	}
}