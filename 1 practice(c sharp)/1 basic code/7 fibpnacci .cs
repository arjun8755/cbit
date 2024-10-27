using System;
using System.Transactions;
class Program
{
    static void Main()
    {
        int a=0,b=1,c,n;
        Console.WriteLine("enter  number of tearm ");
        n=Convert.ToInt32(Console.ReadLine());
       
        for (int i = 0; i <= n; i++)
        { 
         Console.Write(a +"  ");
            c = a + b;
            a = b;
            b = c;
        
        
        }
        
        
        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();
    }
 } 