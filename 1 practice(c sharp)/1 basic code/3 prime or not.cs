using System;

class code
{ 
    static void Main()
    {
        Console.WriteLine("enter  number ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (p(n))
        {

            Console.WriteLine("number is prime");
        }
         else 
            Console.WriteLine("number is not prime");
         
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }
    static bool p(int num)
    { 
     if (num <1)
            return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        { 
         if (num%i==0)
           return false ;      
        }
      return true;  
    }
}