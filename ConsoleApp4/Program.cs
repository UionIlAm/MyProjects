using System;
using System.Collections.Generic;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите трех значное число n");
            string num = Console.ReadLine();
            List<int> asd = new List<int>();
            for (int i = 0; i < num.Length; i++)
                if (int.TryParse(num[i].ToString(), out int res) && asd.Count <= 3)
                    asd.Add(res);


            Console.WriteLine($"число х: {asd[1]}{asd[2]}{asd[0]}");
        }
    }
}
