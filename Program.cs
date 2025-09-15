using System;

class Program
{
    static void Main(string[] args)
    {



        Console.WriteLine("Skriv ditt första tal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Skriv ditt andra tal");
        int tal2 = Convert.ToInt32(Console.ReadLine());

                switch (Console.ReadLine())
        {
            case "+":
                Addition(tal1, tal2);
                break;
            case "-":
                Subtraction(tal1, tal2);
                break;
            case "*":
                Multiplication(tal1, tal2);
                break;
            case "/":
                Division(tal1, tal2);
                break;
            default:
                Console.WriteLine("Ogiltigt val");
                break;
        }


        int resultat = 0;
        Console.WriteLine("Välj räknesätt");

        Console.WriteLine("Resultatet är: " + resultat);
    }
    private int Addition(int tal1, int tal2)
    {
        Console.WriteLine("This is an example method.");
        return tal1 + tal2;
    }

    private int Subtraction(int tal1, int tal2)
    {
        return tal1 - tal2;
    }
    private int Multiplication(int tal1, int tal2)
    {
        return tal1 * tal2;
    }
    private int Division(int tal1, int tal2)
    {
        return tal1 / tal2;
    }
}