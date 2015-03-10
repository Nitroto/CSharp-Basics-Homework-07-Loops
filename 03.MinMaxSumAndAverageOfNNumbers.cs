using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("min = {0}\n\rmax = {1}\n\rsum = {2}\n\ravr = {3:F2}", nums.Min(), nums.Max(), nums.Sum(), nums.Average());
    }
}
