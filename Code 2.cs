using System;			
class Class1
{
	void sum(int a)
	{
		Console.WriteLine(a);
	}
	static void Main(string[] args)
	{
		Class1 class1 = new Class1();
		class1.sum(5);
		Console.ReadLine();
	}
}