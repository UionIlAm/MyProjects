using System;
using System.Collections.Generic;

namespace lb
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine($"a){!A & B}");
            Console.WriteLine($"б){A | !B}");
            Console.WriteLine($"в){A & B | C}");
        }
    }
}
