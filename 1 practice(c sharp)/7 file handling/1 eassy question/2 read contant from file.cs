using System;
using System.IO;

class code
{
    static void Main()
    {
        Console.WriteLine("enter hte file path "); 
        string fp=Console.ReadLine();
        try 
        {
            string[] a = File.ReadAllLines(fp);
            Console.WriteLine("\n contant of the file is \n ");
            foreach (string s in a)
            {

                Console.WriteLine(a);
            }



        }

        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found. Please check the file path.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Error: You do not have permission to access this file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("enter any key for exit ");
        Console.ReadKey();

    }

}