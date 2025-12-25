using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine(c == 0 ? "Infinitate de solutii" : "Fara solutie");
            else
                Console.WriteLine(-c / b);
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("Fara solutii reale");
            else if (delta == 0)
                Console.WriteLine(-b / (2 * a));
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"{x1} {x2}");
            }
        }
    }
}
