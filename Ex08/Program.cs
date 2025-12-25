using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"{a} {b}");
    }
}