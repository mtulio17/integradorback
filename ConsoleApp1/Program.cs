using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MinMaxFinder
{
    public static void FindMinMax(int[] numbers, out int min, out int max)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("El array no puede estar vacío o ser nulo.");

        min = numbers[0];
        max = numbers[0];

        foreach (int number in numbers)
        {
            if (number < min)
                min = number;

            if (number > max)
                max = number;
        }
    }
}

public class Program
{
    public static void Main()
    {
        int[] numbers = { 10, 5, 20, 15, 30, 25 };
        int min, max;
        MinMaxFinder.FindMinMax(numbers, out min, out max);
        Console.WriteLine($"El valor mínimo es: {min}");
        Console.WriteLine($"El valor máximo es: {max}");
        Console.WriteLine("Presiona Enter para salir...");
        Console.ReadLine();
    }
}

