using System;
using System.Text;

namespace Tests
{
	internal class TestHelper
	{
		public static string MixedCase(string value, bool startWithUpper = true)
        {
            var isUpper = startWithUpper;
            var result = new StringBuilder();
            var characterList = value.ToCharArray();

            foreach(var singleCharacter in characterList)
            {
                result.Append((isUpper)?Char.ToUpper(singleCharacter):Char.ToLower(singleCharacter));
                isUpper = !isUpper;
            }

            return result.ToString();
        }
	}
}