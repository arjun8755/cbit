using System;
class Program
{
    static void Main()
    {

        Console.WriteLine("enter a fisrt number");
        int a = int.Parse(Console.ReadLine());
        
        if (pr(a))
        {
            Console.WriteLine($"number{a} is prime");


        }
        else
            Console.WriteLine("number is not prime ");

        static bool pr(int num)
        {

            if (num <= 1) return false; 
            for (int i = 2; i <= Math.Sqrt(num); i++) 
            {
                if (num % i == 0) return false; 
            }
            return true; 
        }

        Console.WriteLine("enter any key for exit");
        Console.ReadKey();



    }
 } 