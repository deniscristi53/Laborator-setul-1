using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int copie = n, inv = 0;

        while (copie > 0)
        {
            inv = inv * 10 + copie % 10;
            copie /= 10;
        }

        Console.WriteLine(n == inv ? "DA" : "NU");
    }
}