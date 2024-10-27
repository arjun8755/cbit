using System;
using System.IO;
using System.Reflection.Metadata;

class code
{
    static void Main()
    {
        Console.WriteLine("enter the filr path");
        string fp = Console.ReadLine();


        if (File.Exists(fp))
        {

            Console.WriteLine($"file is exists");
        }
        else
            Console.WriteLine("file was not foud");



        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}