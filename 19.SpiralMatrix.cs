using System;
using System.Globalization;
using System.Threading;

class SpiralMatrix
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[,] numbers = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;
        for (int i=1; i<=maxRotations;i++) //http://dobromirivanov.net/c-csharp-spiral-matrix/
        {
            if (direction == "right" && (col == n || numbers[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row == n || numbers[row, col] != 0))
            {
                direction = "left";
                col--;
                row--;
            }
            if (direction == "left" && (col < 0 || numbers[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }
            if (direction == "up" && (col < 0 || numbers[row, col] != 0))
            {
                direction = "right";
                col++;
                row++;
            }
            numbers[row, col] = i;
            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        for (int i=0;i<numbers.GetLength(0);i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write("{0,4} |", numbers[i,j]);
            }
            Console.WriteLine();
        }
    }
}
