using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int parteInt = m / n;
        int rest = m % n;

        Console.Write(parteInt + ".");

        Dictionary<int, int> pozitii = new Dictionary<int, int>();
        string zecimale = "";
        int poz = 0;

        while (rest != 0 && !pozitii.ContainsKey(rest))
        {
            pozitii[rest] = poz++;
            rest *= 10;
            zecimale += (rest / n);
            rest %= n;
        }

        if (rest == 0)
        {
            Console.WriteLine(zecimale);
        }
        else
        {
            int start = pozitii[rest];
            Console.WriteLine(
            zecimale.Substring(0, start) + "(" +
            zecimale.Substring(start) + ")"
            );
        }
    }
}