using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Välj räknesätt");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        
        int option = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        Console.WriteLine("Skriv ditt första heltal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv ditt andra heltal");
        int tal2 = Convert.ToInt32(Console.ReadLine());


        switch (option)
        {
            case 1:
                Addition(tal1, tal2);
                break;
            case 2:
                Subtraction(tal1, tal2);
                break;
            case 3:
                Multiplication(tal1, tal2);
                break;
            case 4:
                Division(tal1, tal2);
                break;
            default:
                Console.WriteLine("Ogiltigt val");
                break;
        }
        Console.WriteLine("Resultatet är: " + sum);
    }
    static int Addition(int tal1, int tal2)
    {
        int sum = tal1 + tal2;
        return sum;
    }

    static int Subtraction(int tal1, int tal2)
    {
        int sum = tal1 - tal2;
        return sum;
    }
    static int Multiplication(int tal1, int tal2)
    {
        int sum = tal1 * tal2;
        return sum;        
    }
    static int Division(int tal1, int tal2)
    {
        if (tal2 == 0)
        {
            Console.WriteLine("Fel: Division med noll är inte tillåten.");
            return 0; // eller hantera felet på annat sätt
        }
        int sum = tal1 / tal2;
        return sum;
    }
}