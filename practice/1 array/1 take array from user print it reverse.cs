
using System;
class Program
{

    static void Main(string[] args)
    {
        int[] num = new int[10];
        
       Console.WriteLine("enter ten elemnt of array");
        for (int i = 0; i < 10; i++)
        { 
        
          
            num[i]= Convert.ToInt32(Console.ReadLine());
            
        
        
        
        }



        Console.WriteLine("your array is ");
        
        for (int i = 0; i < num.Length; i++)
        {

         Console.Write(num[i]+ "  ");


        }

        Console.WriteLine("\n revarse of array is ");
        for (int i = 9; i >=0; i--)

        {
            Console.Write(num[i]+"  ");


        }




        Console.ReadLine();
    }
}