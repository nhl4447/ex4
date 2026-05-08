namespace exTrang21
{
    internal class Program
    {
        static void Ex1_EvenOdd()
        {
            Console.WriteLine("\n--- Exercise 1: Even or Odd ---");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine($"{n} is EVEN.");
            else
                Console.WriteLine($"{n} is ODD.");
        }

        // Exercise 2 
        static void Ex2_LargestOfThree()
        {
            Console.WriteLine("\n--- Exercise 2: Largest of Three Numbers ---");
            Console.Write("Enter number A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number B: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number C: "); double c = double.Parse(Console.ReadLine());

            double largest;

            if (a >= b && a >= c)
                largest = a;
            else if (b >= a && b >= c)
                largest = b;
            else
                largest = c;

            Console.WriteLine($"The largest number is: {largest}");
        }

        
        // Exercise 3 
       
        static void Ex3_Quadrant()
        {
            Console.WriteLine("\n--- Exercise 3: XY Coordinate Quadrant ---");
            Console.Write("Input the value for X coordinate: "); double x = double.Parse(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: "); double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the Origin.");
            else if (x == 0)
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
            else
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
        }
    }
}
