using System;

namespace BOOP_02_03
{
    class Program
    {
        public enum PlayingCardColor
        {
            Heart, Diamond, Club, Spade
        }
        public enum PlayingCardValue
        {
            Ace = 1,
            Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Knight, Queen, King
        }
        public struct PlayingCard
        {
            public PlayingCardColor Color;
            public PlayingCardValue Value;
        }
        public enum MonthOfYear
        {
            January, February, March,
            April, May, June,
            July, August, September,
            October, November, December
        }
        static void Main(string[] args)
        {
            MonthOfYear month = MonthOfYear.January;
            Console.WriteLine(month);       // January
            Console.WriteLine((int)month);  // 0

            if (month == MonthOfYear.January) Console.WriteLine("Happy New Year");
        }
    }
}
//Excerices:
//1.    Declare a public enum type PlayingCardColor that models Spade, Club, Heart, Diamond 
//2.    Declare a public enum type PlayingCardValue that models Ace, Two..Ten, Knight, Queen, King
//3.    Declare a public struct PlayingCard that models Color and Value of a playing card. Declare a variable, card1, of 
//      PlayingCard type and assign it to Queen of Heart. 
//4.    Write code to test if card1 is a Queen of Heart. If so Printout "The Queen of them all"

