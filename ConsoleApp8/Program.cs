using System;
using System.Collections.Generic;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число X ");
            int X = Convert.ToInt32(Console.ReadLine());
            double res = 0;
            if (X > 0)
            {
                res = Math.Sin(X * X);
                Console.WriteLine(res);
            }
            else
            {
                res = 1 + 2 * Math.Sin(X);
                Console.WriteLine(res); 
            }
        }
    }
}
