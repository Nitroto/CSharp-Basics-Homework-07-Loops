using System;
using System.Globalization;
using System.Threading;

class NumbersFrom1ToN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(num);
            if (i < n - 1)
            {
                Console.Write(" ");
                }
            num++;
        }
        Console.WriteLine();
    }
}
