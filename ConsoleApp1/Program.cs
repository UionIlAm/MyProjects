using System;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Сторона А");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Сторона B");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"P = {2 * (A + B)}");
            Console.WriteLine($"Длина диоганали: {Math.Sqrt((A * A) + ((B * B)))}");
        }
    }
}
