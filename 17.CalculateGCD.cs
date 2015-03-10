using System;
using System.Globalization;
using System.Threading;

class CalculateGCD
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        Console.WriteLine(a);
    }
}
