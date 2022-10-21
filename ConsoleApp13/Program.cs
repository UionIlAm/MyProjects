namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите стоимость 1кг конфет ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}00г цена {a * i * 0.1}");
            }
        }

    }
}

