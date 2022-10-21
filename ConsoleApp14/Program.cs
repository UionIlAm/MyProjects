namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите баллы за 1 экз ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баллы за 2 экз ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баллы за 3 экз ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баллы за 4 экз ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine(sum = a + b + c + d);
        }

    }
}

