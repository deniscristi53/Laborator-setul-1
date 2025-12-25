using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a > b) (a, b) = (b, a);
        if (a > c) (a, c) = (c, a);
        if (b > c) (b, c) = (c, b);

        Console.WriteLine($"{a} {b} {c}");
    }
}