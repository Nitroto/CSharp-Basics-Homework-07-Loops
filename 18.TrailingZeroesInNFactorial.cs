using System;
using System.Globalization;
using System.Threading;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int numberOfZeros = 0;
        int power = 1;
        bool run = true;
        while (run) //http://www.purplemath.com/modules/factzero.htm
        { 
            int currentNumberOfZeros = n / (int)Math.Pow(5, power);
            if (currentNumberOfZeros > 0)
            {
                numberOfZeros += currentNumberOfZeros;
                power++;
            }
            else
            {
                run = false;
            }
        }
        Console.WriteLine("{0}", numberOfZeros);
    }
}
