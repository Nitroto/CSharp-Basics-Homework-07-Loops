using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        List<int> randomNumbers = new List<int>();
        int initialCount = 1;
        int val;
        Random randomNum = new Random();
        for (int i = 0; i < n; i++)
        {
            while (initialCount <= n)
            {
                val = randomNum.Next(1,(n+1));
                if (!randomNumbers.Contains(val))
                {
                    randomNumbers.Add(val);
                    initialCount++;
                }
            }
        }
        foreach (int value in randomNumbers)
        {
            Console.Write("{0} ", value);
        }
        Console.WriteLine();
    }
}

