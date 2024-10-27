using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter a string");
        string a = Console.ReadLine();
        int count = b(a);
        Console.WriteLine($"length of string is {count}");
    }
    static int b(string str)
    {
        int j = 0;
        foreach (char c in str)
        {
            j++;
        }
        return j;



    }



}