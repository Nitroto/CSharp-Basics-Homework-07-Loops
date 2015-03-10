using System;
using System.Globalization;
using System.Threading;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        long n = long.Parse(Console.ReadLine());
        string result = string.Empty;
        while (n >= 1)
        {
            int remainder = (int)(n % 16);
            n /= 16;
            result = GetHexValue(remainder) + result;
        }
        Console.WriteLine("{0}", result);
    }
    static string GetHexValue(int decimalValue)
    {
        string hexValue = string.Empty;
        switch (decimalValue)
        {
            case 10: hexValue = "A"; break;
            case 11: hexValue = "B"; break;
            case 12: hexValue = "C"; break;
            case 13: hexValue = "D"; break;
            case 14: hexValue = "E"; break;
            case 15: hexValue = "F"; break;
            default: hexValue = decimalValue.ToString(); break;
        }
        return hexValue;
    }
}
