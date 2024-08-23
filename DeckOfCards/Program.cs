using System;

namespace DeckOfCards
{
	public enum PlayingCardColor
	{
		Clubs, Diamonds, Hearts, Spades			// Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace				// Poker Value order
	}
	public struct PlayingCard
	{
		public PlayingCardColor Color;
		public PlayingCardValue Value;

		string FaceOrValue()
		{
			string sRet;
			switch (Value)
			{
				case PlayingCardValue.Ace:
				case PlayingCardValue.Knight:
				case PlayingCardValue.Queen:
				case PlayingCardValue.King:
					sRet = "Face";
					break;

				default:
					sRet = "Value";
					break;
			}
			return sRet;
		}
		string BlackOrRed()
        {
			if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
				return "Black";

			return "Red";
        }
		public string PrintOut() => $"{Value} of {Color}, a {BlackOrRed()} {FaceOrValue()} card";
		public static bool AreEqual(PlayingCard card1, PlayingCard card2) => (card1.Color, card1.Value) == (card2.Color, card2.Value);

		public PlayingCard (PlayingCardColor color, PlayingCardValue value)
        {
			Color = color;
			Value = value;
        }
	}
	class Program
    {
        static void Main(string[] args)
        {
			PlayingCard[] cardDeck1 = new []
			{
				new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Spades },
				new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Hearts },
				new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Clubs },
				new PlayingCard { Value = PlayingCardValue.Ace, Color = PlayingCardColor.Diamonds }
			};

			Console.WriteLine($"cardDeck1 has {cardDeck1.Length} cards");

			PlayingCard[] cardDeck2 = new PlayingCard[52];
			int cardIdx = 0;
			foreach (PlayingCardColor color in typeof(PlayingCardColor).GetEnumValues())
			{
                foreach (PlayingCardValue value in typeof(PlayingCardValue).GetEnumValues())
                {
					cardDeck2[cardIdx].Color = color;
					cardDeck2[cardIdx].Value = value;
					cardIdx++;
                }
			}

			Console.WriteLine($"cardDeck2 has {cardDeck2.Length} cards");

            foreach (var item in cardDeck2)
            {
				Console.WriteLine(item.PrintOut());
            }

			//BOOP_04_02
			PlayingCard singleCard1 = new PlayingCard(PlayingCardColor.Diamonds, PlayingCardValue.Three);

			//BOOP_04_03
			var tupleCard1 = (PlayingCardColor.Diamonds, PlayingCardValue.Knight);
			//var tupleCard2 = (PlayingCardColor.Clubs, PlayingCardValue.Queen);
			var tupleCard2 = (PlayingCardColor.Diamonds, PlayingCardValue.Knight);

			//BOOP_04_04
			if (tupleCard1 == tupleCard2)
				Console.WriteLine("Tuple cards are equal");
			else
				Console.WriteLine("Tuple cards are not equal");

			//PlayingCard singleCard2 = new PlayingCard(PlayingCardColor.Diamonds, PlayingCardValue.Queen);
			PlayingCard singleCard2 = new PlayingCard(PlayingCardColor.Diamonds, PlayingCardValue.Three);

			if (PlayingCard.AreEqual(singleCard1, singleCard2))
				Console.WriteLine("Single cards are equal");
			else
				Console.WriteLine("Single cards are not equal");



			int? idx = FindCard(cardDeck2, PlayingCardColor.Diamonds, PlayingCardValue.Three);
			if (idx.HasValue)
				Console.WriteLine($"Card is found at index {idx}");
			else
				Console.WriteLine("Card not found");

			}

		public static int? FindCard(PlayingCard[] deck, PlayingCardColor color, PlayingCardValue value)
		{
			for (int i = 0; i < 52; i++)
			{
				if ((deck[i].Color, deck[i].Value) == (color, value))
					return i;
			}

			return null;
		}
	}
}
