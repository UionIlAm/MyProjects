namespace lb
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите 3х значное число ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число a ");
            int a = Convert.ToInt32(Console.ReadLine());
            string str_numb = X.ToString();
            List<int> str_list = new List<int>();
            foreach (char _ch in str_numb)
            {
                if (_ch >= '0' && _ch <= '3')
                {
                    str_list.Add(_ch - '0');
                }
            }
            if (str_list[0] + str_list[1] == str_list[2] + str_list[3])
            {
                Console.WriteLine("а) True");
            }
            else
            {
                Console.WriteLine("a) False");
            }
            if (str_list[0] + str_list[1] + str_list[3] + str_list[4] % 3 == 0)
            {
                Console.WriteLine("б) True");
            }
            else
            {
                Console.WriteLine("б) False");
            }
            if (str_list[0] * str_list[1] * str_list[3] * str_list[4] % 4 == 0)
            {
                Console.WriteLine("в) True");
            }
            else
            {
                Console.WriteLine("в) False");
            }
            if (str_list[0] * str_list[1] * str_list[3] * str_list[4] % a == 0)
            {
                Console.WriteLine("г) True");
            }
            else
            {
                Console.WriteLine("г) False");
            }
        }

    }
}
