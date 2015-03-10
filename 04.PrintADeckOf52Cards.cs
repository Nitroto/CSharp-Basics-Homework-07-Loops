using System;
using System.Globalization;
using System.Threading;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] cards = new string[] { "2", "3", "4", "5","6", "7", "8", "9", "10", "J","Q","K","A" };
        char[] suits = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };
        for (int card = 0; card < cards.Length; card++)
        {
            for (int suit = 0; suit < suits.Length; suit++)
            {
                Console.Write("{0}{1} ", cards[card],suits[suit]);
            }
            Console.WriteLine();
        }
    }
}
