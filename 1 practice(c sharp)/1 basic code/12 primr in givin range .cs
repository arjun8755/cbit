
using System;


class Stopwatch
{
    static void Main()
    {
        Console.WriteLine("enter the starting number");
        int s =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the end number of range ");
        int e=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("prime number in givin range is\n ");
        printprime(s,e);
        Console.WriteLine("\n \n enter any key for exit ");
        Console.ReadKey();
    
    }
    static void printprime(int s , int e)
    {
        for (int i = s; i <= e; i++)
        {
            if (isprime(i))
            {
                Console.Write(i + " ");
            }

        }
    }

    static bool isprime(int num)
    { 
     if (num<1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;



    }
}