using System;
namespace Sample_2
{
    class Class2 
        {
            void Swap(ref int a,ref int b)
                {
                int temp=a;
                a=b;
                b=temp;
                Console.WriteLine("------Inside swap func");
                Console.WriteLine("a= "+a);
                Console.WriteLine("b= "+b);
                }
            static void Main()
                {
                Class2 class1=new Class2();
                int a=5,b=6;
                class1.Swap(ref a,ref b);
                Console.WriteLine("inside main func");
                Console.WriteLine("a= "+a);
                Console.WriteLine("b= "+b);
                Console.ReadLine();
                }
        }        
}