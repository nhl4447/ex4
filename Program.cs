 static void Ex1_Calculator()
    {
        Console.WriteLine("\n--- Exercise 1: Calculator ---");
        Console.Write("Enter first number  : "); double a = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+,-,*,x,/): "); string op = Console.ReadLine().Trim();
        Console.Write("Enter second number : "); double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
            case "x":
                Console.WriteLine($"{a} × {b} = {a * b}");
                break;
            case "/":
                if (b == 0)
                    Console.WriteLine("Error: Cannot divide by zero.");
                else
                    Console.WriteLine($"{a} / {b} = {a / b}");
                break;
            default:
                Console.WriteLine($"Unknown operator: '{op}'");
                break;
        }
    }

   
    static void Ex2_Function()
    {
        Console.WriteLine("\n--- Exercise 2: x = y² + 2y + 1 ---");
        Console.WriteLine($"{"y",5} | {"x = y²+2y+1",15}");
        Console.WriteLine(new string('-', 24));

        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;   // equivalent to (y+1)²
            Console.WriteLine($"{y,5} | {x,15}");
        }
    }

  
    static void Ex3_Speed()
    {
        Console.WriteLine("\n--- Exercise 3: Speed Calculator ---");
        Console.Write("Enter distance (km)   : "); double dist = double.Parse(Console.ReadLine());
        Console.Write("Enter time – hours    : "); int h = int.Parse(Console.ReadLine());
        Console.Write("Enter time – minutes  : "); int m = int.Parse(Console.ReadLine());
        Console.Write("Enter time – seconds  : "); int s = int.Parse(Console.ReadLine());

        // Convert total time to hours
        double totalHours = h + m / 60.0 + s / 3600.0;

        if (totalHours == 0)
        {
            Console.WriteLine("Error: Time cannot be zero.");
            return;
        }

        double kmh   = dist / totalHours;
        double mileh = kmh * 0.621371;

        Console.WriteLine($"\nDistance : {dist} km");
        Console.WriteLine($"Time     : {h}h {m}m {s}s  ({totalHours:F4} hours)");
        Console.WriteLine($"Speed    : {kmh:F2} km/h");
        Console.WriteLine($"Speed    : {mileh:F2} miles/h");
    }

 
    static void Ex4_Sphere()
    {
        Console.WriteLine("\n--- Exercise 4: Sphere Surface & Volume ---");
        Console.Write("Enter radius (r): ");
        double r = double.Parse(Console.ReadLine());

        if (r < 0)
        {
            Console.WriteLine("Error: Radius cannot be negative.");
            return;
        }

        double surface = 4 * Math.PI * r * r;
        double volume  = (4.0 / 3.0) * Math.PI * r * r * r;

        Console.WriteLine($"\nRadius  : {r}");
        Console.WriteLine($"Surface : {surface:F4}");
        Console.WriteLine($"Volume  : {volume:F4}");
    }


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
