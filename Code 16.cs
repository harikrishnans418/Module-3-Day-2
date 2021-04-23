using System;
namespace Day_2
{
	class Class16
	{
		public static int Show(params int [] num)
		{
		    int res = 1;
		    foreach(var item in num)
		    {
		        res = res * item;
		    }
		    return res;
		}
		static void Main()
		{
			int x = Show(10, 20, 20, 10);
			Console.WriteLine(x);
			Console.ReadLine();
		}
	}
}