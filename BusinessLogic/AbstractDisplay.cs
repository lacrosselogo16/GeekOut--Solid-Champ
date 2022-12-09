using System.Text;
using HelloWorldProgram.BusinessLogic.Interfaces;

namespace HelloWorldProgram.BusinessLogic
{
	internal abstract class AbstractDisplay:IDisplayable
	{
		protected StringBuilder _result = new StringBuilder();

		public virtual string Display()
		{
			return _result.ToString();
		}
	}
}