using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int d = 1; d <= n; d++)
            if (n % d == 0)
                Console.Write(d + " ");
    }
}
