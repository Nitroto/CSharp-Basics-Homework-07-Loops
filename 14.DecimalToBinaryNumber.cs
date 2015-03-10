using System;
using System.Globalization;
using System.Threading;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        string result=string.Empty;
        while (n>=1)
        {
            int remainder = (int)(n % 2);
            n /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine("{0}", result);
    }
}
