using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 2)
        {
            Console.WriteLine("NU");
            return;
        }

        for (int d = 2; d * d <= n; d++)
            if (n % d == 0)
            {
                Console.WriteLine("NU");
                return;
            }

        Console.WriteLine("DA");
    }
}