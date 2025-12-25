using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = a; i <= b; i++)
            if (i % n == 0)
                count++;

        Console.WriteLine(count);
    }
}