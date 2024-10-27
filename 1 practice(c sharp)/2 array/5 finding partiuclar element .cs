using System;
class Program
{
    static void Main()
    {
        int size,j,k=0;
        Console.WriteLine("enter the size of array");
        size = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[size];         
        Console.WriteLine($"enter the {size} element ");
       
        for (int i = 0; i < a.Length; i++)
        {
            a[i] =Convert.ToInt32( Console.ReadLine());
        }

        Console.WriteLine("enter the element for sarch  ");
        j= Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == j)
            {
                k=5;

                break;
            }

      
        }
        if (k == 5)
        {
            Console.WriteLine($"element {j} was found");
        }

         else
            Console.WriteLine("elemant was not found");
   




        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}