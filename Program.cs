using System;

class Program
{
    static void Main(string[] args)
    {

        int sum = 0;

        // Välj räknesätt
        Console.WriteLine("Välj räknesätt");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        
        int option = int.Parse(Console.ReadLine()!);

        // Mata in tal
        Console.WriteLine("Skriv ditt första heltal");
        int tal1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Skriv ditt andra heltal");
        int tal2 = int.Parse(Console.ReadLine()!);

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

        // Visa resultat
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
            //Hantera division med noll
            Console.WriteLine("Fel: Division med noll är inte tillåten.");
            return 0;
        }
        int sum = tal1 / tal2;
        return sum;
    }
}