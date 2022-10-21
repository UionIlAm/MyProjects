namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число a ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число b ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число c ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a < b && b < c)
                Console.WriteLine("a) True");
            else
                Console.WriteLine("False");
            if (b > a && a > c)
                Console.WriteLine("б) True");
            else
                Console.WriteLine("False");
        }

    }
}

