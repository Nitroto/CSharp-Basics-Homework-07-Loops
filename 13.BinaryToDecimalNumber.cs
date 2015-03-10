using System;
using System.Globalization;
using System.Threading;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string binary = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = binary.Length-1,power =0 ; i >= 0; i--, power++)
        {
            decimalNumber += (binary[i] - '0') * (long) Math.Pow(2, power);
        }
        Console.WriteLine("{0}", decimalNumber);
    }
}
