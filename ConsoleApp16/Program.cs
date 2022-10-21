namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}

