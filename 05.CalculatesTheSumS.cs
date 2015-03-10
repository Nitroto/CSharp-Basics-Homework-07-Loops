using System;
using System.Globalization;
using System.Threading;

class CalculatesTheSumS
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        Decimal nFactorial = 1;
        Decimal s = 1;
        for (int i =1;i<=n;i++)
        {
            nFactorial *= i;
            s += (nFactorial / (decimal)Math.Pow(x,i));
        }
        Console.WriteLine("{0:F5}", s);
    }
}
