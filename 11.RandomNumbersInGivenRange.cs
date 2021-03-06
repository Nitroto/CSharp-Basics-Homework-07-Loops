using System;
using System.Globalization;
using System.Threading;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random randomNum = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ",randomNum.Next(min, max));
        }
        Console.WriteLine();
    }
}
