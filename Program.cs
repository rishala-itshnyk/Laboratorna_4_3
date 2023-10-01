using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c = ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("xp = ");
        double xp = Convert.ToDouble(Console.ReadLine());

        Console.Write("xk = ");
        double xk = Convert.ToDouble(Console.ReadLine());

        Console.Write("dx = ");
        double dx = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("---------------------------");
        Console.WriteLine("|    x     |      F       |");
        Console.WriteLine("---------------------------");

        double x = xp;
        while (x <= xk)
        {
            double F;

            if (x < 0 && b != 0)
            {
                F = a - x / (10 + b);
            }
            else if (x > 0 && b == 0)
            {
                F = (x - a) / (x - c);
            }
            else
            {
                F = 3 * x + (2.0 / c);
            }

            Console.WriteLine($"|  {x,6:F2}  |  {F,10:F2}  |");
            x += dx;
        }

        Console.WriteLine("---------------------------");
    }
}