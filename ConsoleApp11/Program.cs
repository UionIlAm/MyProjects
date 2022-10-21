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

            Console.Write("Введите число d ");
            double d = Convert.ToDouble(Console.ReadLine());

            int negative = 0;
            if (a < 0)
            {
                negative++;
            }

            if (b < 0)
            {
                negative++;
            }

            if (c < 0)
            {
                negative++;
            }
            if (d < 0)
            {
                negative++;
            }

        }

    }
}

