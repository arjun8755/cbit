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

                File.Delete(fp);
                Console.WriteLine("file dleted sucesfully");
            }
            else
                Console.WriteLine("file was not foud");
        }

        catch (Exception ex) 

        {
          Console.WriteLine(ex.ToString());


        }
        
        
        
        
        
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}