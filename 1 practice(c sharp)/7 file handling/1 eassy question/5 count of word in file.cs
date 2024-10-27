using System;
using System.IO;
using System.Reflection.Metadata;

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
                string c = File.ReadAllText(fp);
                char[] delimiters = { ' ', '\r', '\n', '\t', '.', ',', '!', '?', ';', ':' };
                string[] w = c.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                int wc = w.Length;
                Console.WriteLine($"number of words is {wc}");
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