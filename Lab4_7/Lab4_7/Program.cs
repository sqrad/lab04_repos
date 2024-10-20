// Lab4_7.cs
// <Возняк Едвард>
// Лабораторна робота № 4.7
// Обчислення суми ряду Тейлора за допомогою ітераційних циклів та рекурентних співвідношень
// Варіант 5
class Lab4_7
{
    static void Main(string[] args)
    {
        double xp, xk, x, dx, eps, S = 0, a=0, R=0;
        int n = 0;

        Console.WriteLine("Enter xp value:");
        xp = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter xk value:");
        xk = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter dx value:");
        dx = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter eps value:");
        eps = double.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|{0,5} |{1,10} |{2,10} |{3,5} |", "x", "Log((1+x)/(1-x))", "S", "n");
        Console.WriteLine("-------------------------------------------------");

        x = xp;
        while (x <= xk)
        {
            n = 0;
            a = 2;
            S = a;
            do
            {
                n++;
                R = (Math.Pow(x, 2 * n + 1) / (2 * n + 1));
                a *= R;
                S += a;
            } while (Math.Abs(a)>=eps);
            Console.WriteLine("|{0,5:F2} |{1,16:F5} |{2,10:F5} |{3,5} |", x, Math.Log((1.0+x)/(1.0-x)), S, n);

            x += dx;
        }
        Console.WriteLine("-------------------------------------------------");
    }
}

