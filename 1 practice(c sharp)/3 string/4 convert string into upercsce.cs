using System;
using System.IO;

class code
{
    static string ct(string input)
    {
        char[] result  = new char[input.Length];
        for (int i = 0; i < result.Length; i++)
        { 
          char ch = input[i];

            if (ch >= 'a' && ch <= 'z')
            {
                result[i] = (char)(ch - 32);
            }
            else
            {
                
                result[i] = ch;
            }

        }
       return new string(result);
    
    
    }     
    static void Main()
    {
        Console.WriteLine("enter a sting ");
        string fp = Console.ReadLine();
        string output =ct(fp);
        Console.WriteLine("uppercase is  " + output);
        

     
        
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}