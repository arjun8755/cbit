
using System;


class Stopwatch
{
    static void Main()
    {
        Console.WriteLine("enter ammount ");
        Double p= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter rate ");
        Double r = Convert.ToDouble(Console.ReadLine())/100;
        Console.WriteLine("enter time in year ");
        Double t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter how many time ammount was compound");
        int n = Convert.ToInt32(Console.ReadLine());
        Double a =p*Math.Pow(1+ (r/n),n*t);
        Console.WriteLine($"final ammount is {a}");
        Console.WriteLine("press any key for exit ");
        Console.ReadKey();
    
    }

}