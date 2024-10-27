using System;
class Program
{
    static void Main()
    {
        int size,j = 0 ;
        Console.WriteLine("enter the size of array");
        size = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[size];
        int [] b = new int[size];   
        Console.WriteLine($"enter the {size} element ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] =Convert.ToInt32( Console.ReadLine());
        }

        for (int i = 0; i < size; i++, j++)
        {
            b[j] = a[i];




        }
        Console.WriteLine("copyed array is ");
        for (int i = 0; i < size; i++)
        {
            Console.Write (b[i] +" ");
        }
        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}