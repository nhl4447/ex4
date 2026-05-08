namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("y\tx");

            for (int y = -5; y <= 5; y++)
            {
                x = y * y + 2 * y + 1;

                Console.WriteLine(y + "\t" + x);
            }
        }
    }

}
