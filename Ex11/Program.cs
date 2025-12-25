using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = Math.Abs(n);

        while (n > 0)
        {
            Console.Write(n % 10);
            n /= 10;
        }
    }
}
