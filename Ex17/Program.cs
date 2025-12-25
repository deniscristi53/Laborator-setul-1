using System;

class Program
{
    static int Cmmdc(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int d = Cmmdc(a, b);
        int m = a / d * b;

        Console.WriteLine($"CMMDC = {d}");
        Console.WriteLine($"CMMMC = {m}");
    }
}
