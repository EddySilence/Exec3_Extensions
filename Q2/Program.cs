using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*傳回字串的前面幾個字
			  若value 是 null or empty, 都傳回 空字串
			  若 length <= 0, 傳回空字串
			  若value長度比length少, 傳回value*/
			string input = "ashdlqawqhkhewkq";

			input = input.StringLength( 100);
			Console.WriteLine(input);
			input = input.StringLength(5);
			Console.WriteLine(input);
			input = input.StringLength(-2);
			Console.WriteLine(input);
			input = string.Empty;
			input = input.StringLength(3);
			Console.WriteLine(input);
		}
	}
	public static class MyMath
	{
		public static string StringLength(this string input, int length)
		{
			if (string.IsNullOrEmpty(input)) return string.Empty;
			if (length <= 0) return string.Empty;
			if (length > input.Length) return input;
			return input.Substring(0, length);
		}
	}
}
