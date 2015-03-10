using System;
using System.Globalization;
using System.Threading;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string hex = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = hex.Length - 1, power = 0; i >= 0; i--, power++)
        {
            decimalNumber += (GetDecimal(hex[i])) * (long)Math.Pow(16, power);
        }
        Console.WriteLine("{0}", decimalNumber);
    }
    static int GetDecimal(char hexValue)
    {
        int decimalValue = 0;
        switch (hexValue)
        {
            case 'A': decimalValue = 10; break;
            case 'B': decimalValue = 11; break;
            case 'C': decimalValue = 12; break;
            case 'D': decimalValue = 13; break;
            case 'E': decimalValue = 14; break;
            case 'F': decimalValue = 15; break;
            default: decimalValue = hexValue - '0'; break;
        }
        return decimalValue;
    }
}
