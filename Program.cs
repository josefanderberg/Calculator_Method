using System;
using System.Diagnostics.CodeAnalysis;

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

        switch (Console.ReadLine())
        {
            case "+":
                sum = Addition(tal1, tal2);
                break;
            case "-":
                sum = Subtraction(tal1, tal2);
                break;
            case "*":
                sum= Multiplication(tal1, tal2);
                break;
            case "/":
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