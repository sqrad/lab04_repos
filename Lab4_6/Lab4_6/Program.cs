// Lab4_6.cs
// <Возняк Едвард>
// Лабораторна робота № 4.6
// Вкладені цикли
// Варіант 5
class Lab4_6
{
    static void Main(string[] args)
    {
        double P, S;
        int i, k;

        P = 1;
        i = 1;
        while (i<=10)
        {
            S = 0;
            k = 1;
            while (k <= i)
            {
                S += 1.0 / k;
                k++;
            }
            P *= (i + S) / (Math.Sqrt(S));
            i++;
        }
        Console.WriteLine($"P = {P:F8} using while");

        P = 1;
        i = 1;
        do
        {
            S = 0;
            k = 1;
            do
            {
                S += 1.0 / k;
                k++;
            } while (k <= i);
            P *= (i + S) / (Math.Sqrt(S));
            i++;
        } while (i <= 10);
        Console.WriteLine($"P = {P:F8} using do while");

        P = 1;
        for(i =1; i<=10; i++)
        {
            S = 0;
            for(k = 1; k<=i; k++)
            {
                S += 1.0 / k;
            }
            P *= (i + S) / (Math.Sqrt(S));
        }
        Console.WriteLine($"P = {P:F8} using for++");

        P = 1;
        for(i =10; i>= 1; i--)
        {
            S = 0;
            for(k=i; k>=1; k--)
            {
                S += 1.0 / k;
            }
            P *= (i + S) / (Math.Sqrt(S));
        }
        Console.WriteLine($"P = {P:F8} using for--");
    }
}
