using System;
class Program
{

    static void Main()
    {
        int n, c = 0;
        Console.WriteLine("enter a number for sarch");
        n = Convert.ToInt32(Console.ReadLine());
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        bool l = false;


        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] == n)
            {

                l = true;
                break;
            }

            c++;

        }
        if (l)
            Console.WriteLine("number was found on the index " + c);
        else
            Console.WriteLine("number was not found");



        Console.ReadLine();
    }


}