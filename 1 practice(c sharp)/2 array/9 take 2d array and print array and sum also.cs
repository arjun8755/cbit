using System;
class Program
{
    static void Main()
    {
        int r,c,sum=0;
        Console.WriteLine("enter the size of row");
        r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the size of colume");
        c= Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[r,c];
        Console.WriteLine($" enter the {r} by {c} element ");
        for (int j = 0; j < r; j++)
        {
            for (int i = 0; i < c; i++)
            {
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        }
        Console.WriteLine("\n\n");
        
        for (int j = 0; j < r; j++)
        {
            for (int i = 0; i < c; i++)
            {
                Console.Write(a[i, j] + "  ") ;
            }
           Console.WriteLine();
        }
        for (int j = 0; j < r; j++)
        {
            for (int i = 0; i < c; i++)
            {
                sum = sum + a[i, j] ;
            }
            Console.WriteLine();
        }

        Console.WriteLine(sum);

        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}