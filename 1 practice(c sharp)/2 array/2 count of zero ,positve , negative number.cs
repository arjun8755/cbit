class Program
{
    static void Main()
    {
        int j ,pc=0,nc=0,zc=0;
        Console.WriteLine("enter the size of array");
        int size=Convert.ToInt32(Console.ReadLine());
        int []a = new int[size];
        Console.WriteLine($"enter {size} element");
        for (int i = 0; i < size; i++)
        {

          a[i] = Convert.ToInt32(Console.ReadLine());

        }
        j = a[0];

        for (int i = 0; i < size; i++)
        {
            if (a[i] > 1)
            {

                pc++;

            }


            else if (a[i] < 0)
            { 
             nc++;
            
            }
             
            else
                zc++;
        
        }
           Console.WriteLine($"postive number in array is {pc}");
        Console.WriteLine($"neagtive number in array is {nc}");
        Console.WriteLine($" number of zero in array is {zc}");


        Console.WriteLine("\n enter any key for exit");
        Console.ReadKey();

    }
}
