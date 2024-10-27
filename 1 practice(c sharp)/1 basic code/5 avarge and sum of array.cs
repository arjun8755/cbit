using System;
class Program
{
    static void Main()
    {
        int s,sum=0,avg;  
        Console.WriteLine("enter size of array");
        s=Convert.ToInt32(Console.ReadLine());
        int[] v = new int[s];
        Console.WriteLine($"enter {s} element");
        for (int i = 0; i < v.Length; i++)
        {
            v[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0;i < v.Length; i++)
        {
         
            sum = sum + v[i];


        }

        avg = sum / s;
        Console.WriteLine($"sum is {sum} and average is {avg}");


     
        
         Console.WriteLine("enter any key for exit");
        Console.ReadKey();
    }
 } 