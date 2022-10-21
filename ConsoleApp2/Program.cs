using System;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите расстояние в метрах");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{Math.Round(m / 1000, 0, MidpointRounding.ToPositiveInfinity)}");
        }
    }
}
