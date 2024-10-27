using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numb = new List<int>();
        numb.Add(10);
        numb.Add(20);
        numb.Add(30);
        numb.Add(40);
        numb.Add(50);
        Console.WriteLine("\n elemant is list is");
        foreach (int num in numb)
        {
            Console.WriteLine(num); 
        }

        Console.WriteLine($"total number of count is {numb.Count} ");

      
        
        
        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();


    }