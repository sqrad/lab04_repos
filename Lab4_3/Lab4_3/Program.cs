// Lab4_3.cs
// <Возняк Едвард>
// Лабораторна робота № 4.3
// Табуляція функції, заданої формулою: функція з параметроми
// Варіант 5

class Lab4_3
{
    static void Main(string[] args)
    {
        double F;
        double a, b, c, x, xp, xk, dx;

        Console.WriteLine("Enter a value:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b value:");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter c value:");
        c = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter xp value");
        xp = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter xk value");
        xk = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter dx value");
        dx = double.Parse(Console.ReadLine());

        Console.WriteLine("---------------------------");
        Console.WriteLine("|{0,5} |{1,7} |", "x", "F");
        Console.WriteLine("---------------------------");

        x = xp;
        while (x <= xk)
        {
            if (x < 0 && b != 0)
                F = a - (x / (10.0 + b));
            else if (x > 0 && b == 0)
                F = (x - a) / (x - c);
            else
                F = 3 * x + (2.0 / c);
            Console.WriteLine("|{0,7:F2} |{1,10:F3} |", x, F);
            x += dx;
        }
        Console.WriteLine("---------------------------");
    }
}
