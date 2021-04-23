using System;
namespace Day_2
{
class Class14
{
static void Main()
{
Console.WriteLine("Enter a string: ");
string inputString = Console.ReadLine();
int[] charCount = new int[256];
int length = inputString.Length;
for (int index = 0; index < inputString.Length; index++)
{
charCount[inputString[index]]++;
}
int maxcount = -1;
char character = ' ';
for (int i =0; i < length; i++)
{
if(maxcount<charCount[inputString[i]]);
{
maxcount=charCount[inputString[i]];
character = inputString[i];
}
}
Console.WriteLine("The string is {0}" , inputString);
Console.WriteLine("The Highest occurring character us is :"+character+" and count is "+ maxcount);
Console.ReadLine();
}
}
}