using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*針對 string 寫一個擴充方法 ToInt(this string value, int
			  defaultValue), 可以將 string 轉換成 int 型別, 如果無法轉型成
			  功, 傳回 defaultValue*/
			string input = "123";
			int result = input.ToInt(0);
			Console.WriteLine(result);

			input = "31jasd";
			result = input.ToInt(-1);
			Console.WriteLine(result);

		}
	}
	public static class MyString
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool Isint = int.TryParse(value, out int result);
			return Isint ? result : defaultValue;
		}
	}
}
