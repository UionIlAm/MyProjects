using System;
using System.Collections.Generic;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите трех значное число с различными цифрами");
            string num = Console.ReadLine();
            List<int> asd = new List<int>();
            for (int i = 0; i < num.Length; i++)
                if (int.TryParse(num[i].ToString(), out int res) && asd.Count <= 3)
                    asd.Add(res);

            for (int i = 0; i < asd.Count; i++)
                for (int j = 0; j < asd.Count; j++)
                    for (int a = 0; a < asd.Count; a++)
                        if (i != j && i != a && j != a)
                            Console.WriteLine($"{asd[i]}{asd[j]}{asd[a]}");
        }
    }
}
