using System;
using System.IO;

class code
{
    static void Main()
    {
        Console.WriteLine("enter the filr path");
        string fp = Console.ReadLine();
        
        try

        {
            if (File.Exists(fp))
            {
                int c = File.ReadAllLines(fp).Length;
                Console.WriteLine($"file has {c} lines");

            }
            else
                Console.WriteLine("file was not foud");
        }

        catch (Exception ex)

        {

            Console.WriteLine($"an error was found {ex.Message}");
        }

        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }
}