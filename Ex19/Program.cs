using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        n = Math.Abs(n);
        int c1 = (int)(n % 10);
        n /= 10;

        bool ok = true;

        while (n > 0)
        {
            int c = (int)(n % 10);
            if (c != c1)
            {
                ok = false;
                break;
            }
            n /= 10;
        }

        Console.WriteLine(ok ? "DA" : "NU");
    }
}
