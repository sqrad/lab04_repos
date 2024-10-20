// Lab4_5.cs
// <Возняк Едвард>
// Лабораторна робота № 4.5
// "Попадання" у плоску фігуру
// Варіант 5

class Lab4_5
{
    static void Main(string[] args)
    {
        double x, y, R;

        Random random = new Random();

        Console.WriteLine("Enter R value:");
        R = double.Parse(Console.ReadLine());

        for (int i = 0; i< 10; i++)
        {
            Console.WriteLine("Enter x value:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y value:");
            y = double.Parse(Console.ReadLine());
            

            if (x >= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
                x <= 0 && y <= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
                x <= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) && y >= -x)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        for(int i =0; i< 10; i++)
        {
             x = 2 * R * random.NextDouble() - R; 
             y = 2 * R * random.NextDouble() - R; 

            if (x >= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
               x <= 0 && y <= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
               x <= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) && y >= -x)
                Console.WriteLine("{0,8:F4} {1,8:F4} Yes",x, y);
            else
                Console.WriteLine("{0,8:F4} {1,8:F4} No", x, y);
        }
    }
}