using System;

class Program
{
    static void Main()
    { int v=0, c=0;
        Console.WriteLine("enter a string in small later");
        string a = Console.ReadLine();
        foreach (char ch in a)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                v++;
            }
            else
                c++; 
        }

        Console.WriteLine($"number of voviel is {v}");
        Console.WriteLine($"number of consonant is {c}");
        
        
        Console.WriteLine("perss any key for exit");
        Console.ReadKey();






    }

}
