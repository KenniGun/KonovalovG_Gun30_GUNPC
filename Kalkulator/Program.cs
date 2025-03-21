using System;

class Program
{
    static void Main(string[] args)
    {
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a nuber!");
            return;
        }
        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a nuber!");
            return;
        }

        Console.WriteLine("Введите (&, |, ^):");

        var s = Console.ReadLine();
        if (s.Length == 0 || s.Length > 1)
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        int result = 0;

        switch (s[0])
        {
            case '&':
                result = a & b;
                break;
            case '|':
                result = a | b;
                break;
            case '^':
                result = a ^ b;
                break;
            default:
                Console.WriteLine("Error! Invalid operator.");
                return;
        }
        Console.WriteLine($"Десятичное: {result}");
        Console.WriteLine($"Двоичная: {Convert.ToString(result, 2)}");
        Console.WriteLine($"Шестнадцатеричная: {Convert.ToString(result, 16)}");
    }

}