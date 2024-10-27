using System;
class Program
{
    static void Main()
    {
        int s1,s2,j=0;
        Console.WriteLine("enter the size of array");
        s1 = Convert.ToInt32(Console.ReadLine());
        int [] a = new int[s1];
        Console.WriteLine($"enter the {s1} element ");      
        for (int i = 0; i < a.Length; i++)
        {
            a[i] =Convert.ToInt32( Console.ReadLine());
        }

        Console.WriteLine("enter the size of second array");
        s2 = Convert.ToInt32(Console.ReadLine());
        int[] b = new int[s2];
        Console.WriteLine($"enter the {s2} element ");
        for (int i = 0; i < b.Length; i++)
        {
            b[i] = Convert.ToInt32(Console.ReadLine());

        }
        int x = s1 + s2; 
        int[]c = new int[x];
        Console.WriteLine("first array is ");
        for (int i = 0; i < a.Length; i++)
        {
           Console.Write(a[i]+" ");
        }

        Console.WriteLine("\n\n second array is ");
        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }

        for (int i = 0; i < a.Length; i++)
        {
            c[j] = a[i];
            j++;
        }

       
        for (int i = 0; i < b.Length; i++)
        {
            c[j] = b[i];
            j++;
        }
        Console.WriteLine("\n\n marged array is ");
        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i] + " ");
        }


        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}