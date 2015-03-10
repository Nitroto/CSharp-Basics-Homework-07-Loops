using System;
using System.Globalization;
using System.Threading;

class MatrixOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int startNum;
        for (int i = 0; i < n; i++)
        {
            startNum = i + 1;
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", startNum);
                startNum++;
            }
            Console.WriteLine();
        }
    }
}
