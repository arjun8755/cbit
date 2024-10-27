using System;
using System.IO;

class code
{
    static void Main()
    {
        Console.WriteLine("enter the file path");
        string fp = Console.ReadLine();
        try
        {
            if (File.Exists(fp))
            {
                using (StreamReader sr = new StreamReader(fp))
                {
                    string l;
                    Console.WriteLine("csv file contant \n ");
                    while ((l = sr.ReadLine()) != null)
                    {
                        string[] f = l.Split(',');
                        Console.WriteLine(string.Join(" | ", f));

                    }
                }
            }


            else
                Console.WriteLine("The specified file does not exist.");
        }

        catch (Exception ex)

        {
            Console.WriteLine(ex.ToString());


        }
        
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}