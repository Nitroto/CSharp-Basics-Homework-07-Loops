using System;
using System.Globalization;
using System.Threading;
using System.Numerics;

class CalculateNumberOfCombinations
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int diff = n - k;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger diffFactorial = 1;
        bool run = true;
        while (run)
        {
            if (n==1)
            {
                run = false;
            }
            if (n > 1)
            {
                nFactorial *= n;
                n--;
            }
            if (k > 1)
            {
                kFactorial *= k;
                k--;
            }
            if (diff > 1)
            {
                diffFactorial *= diff;
                diff--;
            }
        }
        Console.WriteLine("{0}", nFactorial / (kFactorial*diffFactorial));
    }
}
