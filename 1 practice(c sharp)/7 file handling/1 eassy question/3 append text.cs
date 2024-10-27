using System;
using System.IO;

class code
{
    static void Main()
    {
        Console.WriteLine("enter the filr path");
        string fp = Console.ReadLine();
        Console.WriteLine("enter the text to append");
        string t = Console.ReadLine().Trim();
        try

        {
            File.AppendAllText(fp, t + Environment.NewLine);
            Console.WriteLine("text was append");


        }

        catch (Exception ex)

        {

            Console.WriteLine($"an error was found {ex.Message}");
        }




    }
}