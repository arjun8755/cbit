using System;
class Program
{
    static void Main()
    {
        int size,j=0,c=0;
        Console.WriteLine("enter the size of array");
        size = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[size];         
        Console.WriteLine($"enter the {size} element ");
        a[1] = j;
        for (int i = 0; i < a.Length; i++)
        {
            a[i] =Convert.ToInt32( Console.ReadLine());
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (j < a[i])
            {
                c = j;
                j = a[i];
               
            }

      
        }
            Console.WriteLine($"the second higest element was {c} ");
   




        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}