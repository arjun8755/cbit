using System;
class Program
{
    static void Main()
    {
        int a,r,u=0;
        Console.WriteLine("enter any number ");
        int s=Convert.ToInt32(Console.ReadLine());
        a = s;      
        while (s!=0)
        {
            r = s % 10;
            u = u * 10 + r;
            s=s/10; 
        }
        if (u == a)
        {
            Console.WriteLine("number is palindrom");
        }
       else
        Console.WriteLine("number is not palindrom");
        
        
        Console.WriteLine("enter any key for exit");
        Console.ReadKey();
    }
 }   
