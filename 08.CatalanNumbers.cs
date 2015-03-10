using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

class CatalanNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int twoN = 2 * n;
        int nPlusOne = n + 1;
        BigInteger twoNFactorial = 1;
        BigInteger nFactorial = 1;
        BigInteger nPlusOneFactorial = 1;
        bool run = true;
        while (run)
        {
            if (twoN <= 1)
            {
                run = false;
            }
            if (n >1)
            {
                nFactorial *= n;
                n--;
            }
            if (nPlusOne > 1)
            {
                nPlusOneFactorial *= nPlusOne;
                nPlusOne--;
            }
            if (twoN > 1)
            {
                twoNFactorial *= twoN;
                twoN--;
            }
        }
        BigInteger catalanNumber = twoNFactorial / (nPlusOneFactorial * nFactorial);
        Console.WriteLine("{0}",catalanNumber);
    }
}
