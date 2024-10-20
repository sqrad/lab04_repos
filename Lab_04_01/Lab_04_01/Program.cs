// Lab_04_1.cs
// <Возняк Едвард>
// Лабораторна робота №4.1
// Цикли
// Варіант 5
class Lab4_1 
{
static void Main(string[] args)
    {
        double result = 1;
        int i;

        // using cycle for(i++)
        for (i = 1; i <= 15; i++)
        {
            double term = (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
            result *= term;
        }
        Console.WriteLine("Result with for (...; ...; i++): " + result);

        // Restart results
        result = 1;
        i = 1;

        // using cycle while
        while (i <= 15)
        {
            double term = (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
            result *= term;
            i++;
        }
        Console.WriteLine("Result with while: " + result);

        // Restart results
        result = 1;
        i = 1;

        // using cysle do-while
        do
        {
            double term = (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
            result *= term;
            i++;
        }
        while (i <= 15);
        Console.WriteLine("Result with do-while: " + result);

        // Restart results
        result = 1;
        i = 15;

        // using cycle for (...; ...; i--)
        for (; i >= 1; i--)
        {
            double term = (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
            result *= term;
        }
        Console.WriteLine("Result with for (...; ...; i--): " + result);
    }
}

