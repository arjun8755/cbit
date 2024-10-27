
using System;
using System.Threading;

class Stopwatch
{
    static void Main()
    {
        Console.WriteLine("Stopwatch started:");

        for (int seconds = 1; seconds <= 10; seconds++)
        {
            Console.WriteLine($"Time: {seconds} second(s)");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Stopwatch ended!");
        Console.WriteLine("press any key for exit ");
         Console.ReadKey();
    
    
    } 

}