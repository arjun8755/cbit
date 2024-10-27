using System;
using System.IO;
using System.Reflection.Metadata;
class code
{
    static void Main()
    {
        string p = @"D:\text output"; //  path to the file

        string n = "1 file handling .txt";
        string fp = Path.Combine(p, n);
        string c = "hello this is our fist file handling ";
        try
        {
            if (!Directory.Exists(p))
            {
                Directory.CreateDirectory(p);
            }


            using (StreamWriter writer = new StreamWriter(fp))
            {
                writer.WriteLine(c);
            }
            Console.WriteLine($"File '{n}' created and text written successfully at '{fp}'.");

        }

        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

}