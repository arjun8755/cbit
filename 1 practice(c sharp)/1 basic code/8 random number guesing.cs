using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int sn = random.Next(1, 101);

        int mn;

        while (true)
        {
            Console.WriteLine("enter your guse number");
            mn=Convert.ToInt32(Console.ReadLine());


            if (sn == mn)
            {

                Console.WriteLine("you guse right number");
                break;

            }
            else if (sn >mn)
            {
                Console.WriteLine("youe guse is less ");
            }

            else
                Console.WriteLine("your guse is hige");

        }
        
    }
 }  