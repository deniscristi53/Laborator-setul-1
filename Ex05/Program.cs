using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        n = Math.Abs(n);

        for (int i = 1; i < k; i++)
            n /= 10;

        Console.WriteLine(n % 10);
    }
}