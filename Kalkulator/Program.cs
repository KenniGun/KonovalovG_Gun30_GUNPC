using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error! Invalid input for the first number.");
            return;
        }

        Console.WriteLine("Введите второе число:");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error! Invalid input for the second number.");
            return;
        }

        Console.WriteLine("Введите (&, |, ^):");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        int result = 0;
        switch (op)
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
        Console.WriteLine($"Шестнадцатеричная: {result:X}");
    }
}
