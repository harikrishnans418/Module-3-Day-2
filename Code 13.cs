using System;  
class Class13 
{  
    static void Main() 
{
    string str;
    int i, l, v;
      Console.Write("Enter the word : ");
      str = Console.ReadLine();		

    v = 0;
    l = str.Length;

    for(i=0; i<l; i++)
    {

        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
        {
            v++;
        }
        
    }
   Console.Write("\nThe total number of vowels in the word is : {0}\n", v);
   	}
}
