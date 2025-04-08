using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть рядок зі словами, розділеними комами: ");
        string input = Console.ReadLine();

        string cleanedString = input.Replace(" ", "");

        Console.WriteLine($"Результат: {cleanedString}");
    }
}
