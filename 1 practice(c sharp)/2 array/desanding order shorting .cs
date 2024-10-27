using System;
class Program
{
    static void Main()
    {
        int size,temp;
        Console.WriteLine("enter the size of array");
        size = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[size];
        Console.WriteLine($"enter the {size} element ");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] =Convert.ToInt32( Console.ReadLine());
        }

        for (int i = 0; i < a.Length -1; i++)
        {

            for (int j = i + 1; j < a.Length; j++)
            {


                if (a[i] < a[j])

                {
                     temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }

        }


        for (int i = 0; i < a.Length; i++)
        {
            Console.Write (a[i] +" ");
        }
        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}