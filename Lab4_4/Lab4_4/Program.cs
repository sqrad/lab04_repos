// Lab4_4.cs
// <Возняк Едвард>
// Лабораторна робота № 4.4
// Табуляція функції, заданої графіком
// Варіант 5

class Lab4_4
{
    static void Main(string[] args)
    {
        double y, x, xp, xk, dx, R;

        Console.WriteLine("Enter R value:");
        R = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter xp value");
        xp = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter xk value");
        xk = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter dx value");
        dx = double.Parse(Console.ReadLine());


        Console.WriteLine("---------------------------");
        Console.WriteLine("|{0,5} |{1,7} |", "x", "y");
        Console.WriteLine("---------------------------");

        x = xp;

        while (x <= xk)
        {
            if (-4 < x && x < -2)
                y = x + 3;
            else if (-2 < x && x < 4)
                y = 1 + ((-R - 1) / (4 + 2)) * (x + 2);
            else if (4 < x && x < 8 - R)
                y = -R;
            else if (8 - R < x && x < 8 + R)
                y = -R + Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x - 8, 2));
            else
                y = -R;
            Console.WriteLine("|{0,7:F2} |{1,10:F3} |", x, y);
            x += dx;
        }
        Console.WriteLine("---------------------------");
    }
}
