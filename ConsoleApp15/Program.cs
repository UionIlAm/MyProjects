namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите оценку за 1 предмет ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 2 предмет ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 3 предмет ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 4 предмет ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 5 предмет ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 6 предмет ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 7 предмет ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 8 предмет ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 9 предмет ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите оценку за 10 предмет ");
            int o = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(((a + b + c + d + e + f + g + h + i + o) / 10));
        }

    }
}

