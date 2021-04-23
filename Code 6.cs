using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter something ");
        var a= Console.ReadLine();
       int result;
       int.TryParse(a, out result);
       if(result == 0)
          Console.WriteLine("Not a number");
       else
          Console.WriteLine("it is a number");
       Console.ReadLine();
    }
}