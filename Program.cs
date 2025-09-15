using System;

class Program
{
    static void Main(string[] args)
    {

        int sum = 0;
        Console.WriteLine("Skriv ditt första heltal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv ditt andra heltal");
        int tal2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Välj räknesätt");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                sum = Addition(tal1, tal2);
                break;
            case 2:
                sum = Subtraction(tal1, tal2);
                break;
            case 3:
                sum = Multiplication(tal1, tal2);
                break;
            case 4:
                sum = Division(tal1, tal2);
                break;
            default:
                Console.WriteLine("Ogiltigt val");
                break;
        }
        Console.WriteLine("Resultatet är: " + sum);
    }
    static int Addition(int tal1, int tal2)
    {
        return tal1 + tal2;
    }

    static int Subtraction(int tal1, int tal2)
    {
        return tal1 - tal2;
    }
    static int Multiplication(int tal1, int tal2)
    {
        return tal1* tal2;
    }
    static int Division(int tal1, int tal2)
    {
        return tal1 / tal2;
    }
}