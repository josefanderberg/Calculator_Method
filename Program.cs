using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        int tal1;
        int tal2;
        int sum = 0;

        // Välj räknesätt
        Console.WriteLine("Välj räknesätt");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        
        
        while(true)
        {
            Console.Write("Ange ditt val (1-4): ");
            if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ogiltigt val");
            }
        }
        
        while(true)
        {
            Console.WriteLine("Skriv ditt första heltal");
            if (int.TryParse(Console.ReadLine(), out tal1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ogiltigt tal, försök igen.");
            }
        }

        while(true)
        {
            Console.WriteLine("Skriv ditt andra heltal");
            if (int.TryParse(Console.ReadLine(), out tal2))
            {
                if (tal2 == 0)
                {
                Console.WriteLine("Fel: Division med noll är inte tillåten.");
                }
                else
                {
                break;
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt tal, försök igen.");
            }
        }

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
        int sum = tal1 / tal2;
        return sum;
    }
}