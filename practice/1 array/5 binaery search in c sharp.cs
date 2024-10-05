using System;



namespace ConsoleApp1
{
    internal class Program
    {

        static int bs(int[] j, int t)

        {
            int low = 0;
            int high = j.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (j[mid] == t)
                {
                    return mid; // Element mil gaya
                }
                else if (j[mid] < t)
                {
                    low = mid + 1; // Target element array ke right half mein hoga
                }
                else
                {
                    high = mid - 1; // Target element array ke left half mein hoga
                }




            }

            return -1;


        }



        static void Main(string[] args)
        {
            int a, t, j;
            Console.WriteLine("enter number of elemnnt for array");
            a = Convert.ToInt32(Console.ReadLine());


            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("enter the nyumber  for sarch");
            t = int.Parse(Console.ReadLine());
            j = bs(arr, t);

            if (j != -1)
            {
                Console.WriteLine($"Number {t} found at index {j}");
            }
            else
            {
                Console.WriteLine("Number not found.");
            }






            Console.ReadLine();

        }
    }
}