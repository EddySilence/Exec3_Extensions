using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*IsOdd()傳回 bool , 表示是否為奇數
			 IsEven()傳回 bool , 表示是否為偶數*/

			bool isOdd = MyMath.IsOdd(2);

			bool isEven = MyMath.IsEven(3);

			Console.WriteLine(isOdd);
			Console.WriteLine(isEven);

		}
	}
	public static class MyMath
	{
		public static bool IsOdd(this int number)
		{
			return number % 2 == 1;
		}
		public static bool IsEven(this int number)
		{
			return number % 2 == 0;
		}
	}

}
