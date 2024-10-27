using System;
using System.Data;
using System.Threading;
class Program
{
    static void Main()
    {
        int j;
        Console.WriteLine("enter the size of array");
        int size=Convert.ToInt32(Console.ReadLine());
        int []a = new int[size];
        Console.WriteLine($"enter {size} element");
        for (int i = 0; i < size; i++)
        {

          a[i] = Convert.ToInt32(Console.ReadLine());

        }
        j = a[0];

        for (int i = 0; i < size; i++)
        { 
          if (j > a[i])
            {

              j = a[i];

            }
        
        
        }
           Console.WriteLine($"lest number in array is {j}");


            Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}