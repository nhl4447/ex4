namespace trang22
{
    internal class Program
    {
        // ─────────────────────────────────────────────
        // 1. Triangle Type
        // ─────────────────────────────────────────────
        static void Ex1_TriangleType()
        {
            Console.WriteLine("--- Exercise 1: Triangle Type ---");
            Console.Write("Enter side A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side B: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side C: "); double c = double.Parse(Console.ReadLine());

            // Check if it forms a valid triangle
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Not a valid triangle.");
                return;
            }

            if (a == b && b == c)
                Console.WriteLine("Equilateral triangle");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles triangle");
            else
                Console.WriteLine("Scalene triangle");
        }

        // ─────────────────────────────────────────────
        // 2. Average & Sum of 10 numbers
        // ─────────────────────────────────────────────
        static void Ex2_AverageSum()
        {
            Console.WriteLine("--- Exercise 2: Average & Sum ---");
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum     = {sum}");
            Console.WriteLine($"Average = {sum / 10}");
        }

        // ─────────────────────────────────────────────
        // 3. Multiplication Table
        // ─────────────────────────────────────────────
        static void Ex3_MultiplicationTable()
        {
            Console.WriteLine("--- Exercise 3: Multiplication Table ---");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i,2} = {n * i,4}");
        }

        // ─────────────────────────────────────────────
        // 4. Number Triangle Pattern  (left pattern)
        //    1
        //    12
        //    123
        //    1234
        // ─────────────────────────────────────────────
        static void Ex4_NumberTriangle()
        {
            Console.WriteLine("--- Exercise 4: Number Triangle ---");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
        }

        // ─────────────────────────────────────────────
        // 5. Three Patterns
        //
        //  Pattern A    Pattern B      Pattern C
        //  1            1              1
        //  12           2 3            2 3
        //  123          4 5 6          4 5 6
        //  1234         7 8 9 10       7 8 9 10
        // ─────────────────────────────────────────────
        static void Ex5_ThreePatterns()
        {
            Console.WriteLine("--- Exercise 5: Three Patterns ---");
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            // Pattern A
            Console.WriteLine("\nPattern A:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            // Pattern B  (consecutive numbers, new row each line)
            Console.WriteLine("\nPattern B:");
            int num = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(num++ + " ");
                Console.WriteLine();
            }

            // Pattern C  (right-aligned triangle with consecutive numbers)
            Console.WriteLine("\nPattern C:");
            num = 1;
            int totalNums = rows * (rows + 1) / 2; // total count
                                                   // rebuild per row with spacing aligned to max row width
            num = 1;
            for (int i = 1; i <= rows; i++)
            {
                // leading spaces to right-align
                int spaces = rows - i;
                Console.Write(new string(' ', spaces * 3));
                for (int j = 1; j <= i; j++)
                    Console.Write($"{num++,-3}");
                Console.WriteLine();
            }
        }

        // ─────────────────────────────────────────────
        // 6. Harmonic Series  1 + 1/2 + 1/3 + ... + 1/n
        // ─────────────────────────────────────────────
        static void Ex6_HarmonicSeries()
        {
            Console.WriteLine("--- Exercise 6: Harmonic Series ---");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write(i == 1 ? "1" : $" + 1/{i}");
            }
            Console.WriteLine($"\nSum = {sum:F6}");
        }

        // ─────────────────────────────────────────────
        // 7. Perfect Numbers in Range
        //    A perfect number equals the sum of its proper divisors.
        //    e.g. 6 = 1 + 2 + 3
        // ─────────────────────────────────────────────
        static void Ex7_PerfectNumbers()
        {
            Console.WriteLine("--- Exercise 7: Perfect Numbers ---");
            Console.Write("Enter start of range: "); int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end of range:   "); int end = int.Parse(Console.ReadLine());

            Console.Write("Perfect numbers: ");
            bool found = false;
            for (int n = start; n <= end; n++)
            {
                int divisorSum = 0;
                for (int d = 1; d < n; d++)
                    if (n % d == 0) divisorSum += d;

                if (divisorSum == n)
                {
                    Console.Write(n + " ");
                    found = true;
                }
            }
            if (!found) Console.Write("None");
            Console.WriteLine();
        }

        // ─────────────────────────────────────────────
        // 8. Prime Number Check
        // ─────────────────────────────────────────────
        static void Ex8_PrimeCheck()
        {
            Console.WriteLine("--- Exercise 8: Prime Check ---");
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine($"{n} is NOT prime.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { isPrime = false; break; }
            }

            Console.WriteLine(isPrime ? $"{n} is PRIME." : $"{n} is NOT prime.");
        }
    }
}