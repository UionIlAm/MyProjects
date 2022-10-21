namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите число X ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число Y ");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число Z ");
            int Z = Convert.ToInt32(Console.ReadLine());

            if ((X & Y) % 2 != 0)
            {
                Console.WriteLine("a) True");
            }
            else
            {
                Console.WriteLine("a) False");
            }
            if ((X & Y) < 20)
            {
                Console.WriteLine("б) True");
            }
            else
            {
                Console.WriteLine("б) False");
            }
            if ((X & Y) == 0)
            {
                Console.WriteLine("в) True");
            }
            else
            {
                Console.WriteLine("в) False");
            }
            if ((X & Y & Z) < 0)
            {
                Console.WriteLine("г) True");
            }
            else
            {
                Console.WriteLine("г) False");
            }
            if ((X | Y | Z) % 5 == 0)
            {
                Console.WriteLine("д) True");
            }
            else
            {
                Console.WriteLine("д) False");
            }
            if ((X & Y & Z) > 100)
            {
                Console.WriteLine("е) True");
            }
            else
            {
                Console.WriteLine("е) False");
            }
        }
    }
}

