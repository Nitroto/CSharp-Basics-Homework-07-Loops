using System;
using System.Globalization;
using System.Threading;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            if ((num % 3 != 0) && (num % 7 != 0))
            {
                Console.Write(num);
                if (i < n - 1)
                {
                    Console.Write(" ");
                }
            }
            num++;
        }
        Console.WriteLine();
    }
}
