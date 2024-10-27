using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("enter the string without spase  ");
      
        string a= Console.ReadLine();
        string c= rs(a);
        Console.WriteLine("Reversed string: " + c);




        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();


    }

    static string rs(string str)
    {
        char[] re=new char[str.Length];
        int j = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            re[j++] = str[i];
        }

        return new string (re);
    }
