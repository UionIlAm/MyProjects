namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число месяца ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 3)
            {
                Console.WriteLine("Весна");
            }
            if (a == 4)
            {
                Console.WriteLine("Весна");
            }
            if (a == 5)
            {
                Console.WriteLine("Весна");
            }
            if (a == 6)
            {
                Console.WriteLine("Лето");
            }
            if (a == 7)
            {
                Console.WriteLine("Лето");
            }
            if (a == 8)
            {
                Console.WriteLine("Лето");
            }
            else
            {
                Console.WriteLine("Cентябрь");
            }
        }

    }
}

