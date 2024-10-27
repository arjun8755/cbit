using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> a = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        foreach (int num in a)
        {
            Console.WriteLine(num);
        }
         Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();


    }