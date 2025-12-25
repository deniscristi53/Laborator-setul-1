using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = 2;

        while (n > 1)
        {
            int p = 0;
            while (n % d == 0)
            {
                n /= d;
                p++;
            }
            if (p > 0)
                Console.Write($"{d}^{p} ");
            d++;
        }
    }
}