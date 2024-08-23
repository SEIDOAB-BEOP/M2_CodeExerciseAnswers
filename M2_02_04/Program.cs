using System;

namespace BOOP_02_04
{
    class Program
    {
        [Flags]
        public enum PlayingCardColor
        {
            Heart = 0b1,
            Diamond = 0b1 << 1,
            Club = 0b1 << 2,
            Spade = 0b1 << 3,

            Red = Heart | Diamond,
            Black = Club | Spade
        }
        public enum PlayingCardValue
        {
            Ace = 1,
            One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Knight, Queen, King
        }
        public struct PlayingCard
        {
            public PlayingCardColor Color;
            public PlayingCardValue Value;
        }

        [Flags]
        public enum MonthOfYear
        {
            Undefined = 0,
            January = 0b1, February = 0b1 << 1, March = 0b1 << 2,
            April = 0b1 << 3, May = 0b1 << 4, June = 0b1 << 5,
            July = 0b1 << 6, August = 0b1 << 7, September = 0b1 << 8,
            October = 0b1 << 9, November = 0b1 << 10, December = 0b1 << 11,

            Q1 = January | February | March,
            Q2 = April | May | June,
            Q3 = July | August | September,
            Q4 = October | November | December
        }
        static void Main(string[] args)
        {
            MonthOfYear month = MonthOfYear.January;
            Console.WriteLine(month);       // January
            Console.WriteLine((int)month);  // 1

            if (month == MonthOfYear.January) Console.WriteLine("Happy New Year");
            if ((month & MonthOfYear.Q1) != 0) Console.WriteLine("We are in 1st Quarter");
            if ((month & MonthOfYear.Q2) != 0) Console.WriteLine("We are in 2nd Quarter");
        }
    }
}
//Excerices:
//1.    Modify enum type PlayingCardColor from exercise BOOP_02_03 and add members "Red" if PlayingCardColor is Heart or Diamond and
//      Black if PlayingCardColor is Club or Spade.
//2.    Declare a variable, card1, of type PlayingCard assign members Color and Value
//3.    Write code to test if card1 is is Red - if so Printout "a Red Card". If Black Printout "a Black Card"
