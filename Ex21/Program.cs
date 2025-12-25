using System;

class Program
{
    static void Main()
    {
        int st = 1, dr = 1024;

        while (st < dr)
        {
            int mid = (st + dr) / 2;
            Console.WriteLine($"Numarul este >= {mid}? (da/nu)");
            string raspuns = Console.ReadLine();

            if (raspuns == "da")
                st = mid;
            else
                dr = mid - 1;
        }

        Console.WriteLine($"Numarul este {st}");
    }
}