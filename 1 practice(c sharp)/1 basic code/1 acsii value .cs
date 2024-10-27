using System;

class code
{ 
    static void Main()
    {
        Console.WriteLine("enter a santance ");
        string fp = Console.ReadLine();
        foreach (char c in fp)
        {
            Console.WriteLine("ascii valuse is  " +(int)c);
        
        
        }
       
        

     
        
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}