using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = int.MinValue;
        int minDigit = int.MaxValue;

        while (number > 0)
        {
            int digit = number % 10;
            maxDigit = Math.Max(maxDigit, digit);
            minDigit = Math.Min(minDigit, digit);
            number /= 10;
        }

        Console.WriteLine($"Максимальна цифра: {maxDigit}");
        Console.WriteLine($"Мінімальна цифра: {minDigit}");
    }
}
