namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một ký tự: ");
            string input = Console.ReadLine();

            if (input.Length != 1)
            {
                Console.WriteLine("Vui lòng chỉ nhập ĐÚNG MỘT ký tự.");
                return;
            }

            char c = input[0];

            if ("aeiouAEIOU".IndexOf(c) >= 0)
                Console.WriteLine($"'{c}' là NGUYÊN ÂM.");
            else if (char.IsDigit(c))
                Console.WriteLine($"'{c}' là CHỮ SỐ.");
            else
                Console.WriteLine($"'{c}' là KÝ TỰ KHÁC.");
        }
    }
}
