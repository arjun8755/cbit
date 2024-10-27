using System;

class Program
{
    static void Main()
    {
        int size;
        Console.WriteLine("entre the size of element ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Console.WriteLine("enter the size of array");
        for (int i = 0; i < size; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        int newsize = rd(array, size);
        Console.WriteLine("array with out dublicat is ");
        for (int i = 0; i < newsize; i++)
        {
            Console.Write(array[i] + "  ");
        }
    }
    static int rd(int[] arr, int size)
    {
        int newsize = 0;
        for (int i = 0; i < size; i++)
        {
            bool dub = false;
            for (int j = 0; j < newsize; j++)
            {

                if (arr[i] == arr[j])
                {
                    dub = true;
                    break;
                }

            }
            if (!dub)
            {
                arr[newsize] = arr[i];
                newsize++;
            }
        }

      return newsize;


    }

}    
