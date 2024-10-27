using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string a = Console.ReadLine();
        if(bi(a))
        {
            Console.WriteLine($"{a} is palindrom");

        }
        else
            Console.WriteLine($"{a} is not palindrom");


        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();


    }
    static bool bi(string str)
    { 
    
      int l=0,r=str.Length-1;
        while (l < r)
        {
            if (char.ToLower(str[l]) != (char.ToLower(str[r])) )
            { return false;

            }
            l++;
             r--;
        }
    
    
        return true;
    
    
    }
    






}