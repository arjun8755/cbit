using System;
class Program
{
    static void Main()
    {
        int s,j;
        Console.WriteLine("enter a number or 0 for exit");
        int a = int.Parse(Console.ReadLine());
        while (a != 0)
        {
            j = a;
            for (int i = 1; i <= 10; i++)
            {
                 s = j* i;                       
                Console.WriteLine($"{j}*{i}={s}");
                
            
            
            }
            Console.WriteLine("enter number for table or 0 for exit");
             a = int.Parse(Console.ReadLine()); 
             
        
        
        
        }
    }
 } 