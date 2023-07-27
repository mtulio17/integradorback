using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegral.P2
{

    public class FactorialCalculator
    {
        public static int CalculateFactorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("El número debe ser mayor o igual a cero.");

            if (number == 0 || number == 1)
                return 1;

            int factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int number = 8;
            int factorial = FactorialCalculator.CalculateFactorial(number);
            Console.WriteLine($"El factorial de {number} es: {factorial}");
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }
    }



}
