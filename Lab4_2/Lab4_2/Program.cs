// Lab4_2.cs
// <Возняк Едвард>
// Лабораторна робота № 4.2
// Табуляція функції, заданої формулою: функція однієї змінної
// Варіант 5

class Lab4_2
{
    static void Main(string[] args)
    {
        double x, xp, xk, dx, A, B, y;

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
        while(x <= xk)
        {
            A = ((1.0) / (Math.Abs(x + 2))) + 1;
            if (x<1)
                B = 7 * Math.Pow(x, 2) + x - 8;
            else if(1<=x && x<=4)
                B = (1.0 / Math.Tan((x + 4) / Math.Sqrt(11))) + 3; // ctg = 1/tan x
            else
                B = Math.Sqrt(1 + Math.Abs(Math.Pow(Math.Cos(x), 3)));

            y = A - B;
            Console.WriteLine("|{0,7:F2} |{1,10:F3} |", x, y);
            x += dx;
        }
        Console.WriteLine("---------------------------");
    }
}