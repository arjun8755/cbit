using System;

class code
{ 
    static void Main()
    {
        Console.WriteLine("enter first number ");
        double n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter second number");
        double n2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter oprent + ,-,*,/ only");
        char op= Convert.ToChar(Console.ReadLine());
        double result;
        
        switch (op)
        {
            case '+':
                result =n1 + n2;
                Console.WriteLine($"result is {result}");
                break;

            case '-':
                result = n1-n2;
                Console.WriteLine($"result is {result}");
                break;

            case '*':
                result = n1*n2;
                Console.WriteLine($"result is {result}");
                break;

            case '/':
                if (n2 != 0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"result is {result}");

                }
                else
                    Console.WriteLine("divistion by 0 in invalid");
                 break;

            default:
                Console.WriteLine("Error: Invalid operator.");
                break;



        }
        Console.WriteLine("\n enter any key for exit ");
        Console.ReadKey();

    }

}