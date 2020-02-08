using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	/// <summary>
	/// A deck of cards
	/// </summary>
	class Deck
	{
		#region Fields

		List<Card> deck = new List<Card>();

		#endregion

		#region Properties

		/// <summary>
		/// Gets whether the deck is empty
		/// </summary>
		public bool Empty
		{
			get { return deck.Count == 0; }
		}

		#endregion

		#region Constructors
		
		/*
		/// <summary>
		/// Constructor
		/// </summary>
		public Deck()
		{
			// fill the deck with cards
			foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
			{
				foreach (Name name in Enum.GetValues(typeof(name)))
				{
					foreach ( )
					deck.Add(new Card(rank.ToString(), suit.ToString()));
				}
			}
		} 
		*/

		#endregion

		#region Methods

		/*
		/// <summary>
		/// Cuts the deck of cards at the given location
		/// </summary>
		/// <param name="location">the location at which to cut the deck</param>
		public void Cut(int location)
		{
			int cutIndex = deck.Count - location;
			Card[] newCards = new Card[deck.Count];
			deck.CopyTo(cutIndex, newCards, 0, location);
			deck.CopyTo(0, newCards, location, cutIndex);
			deck.Clear();
			deck.InsertRange(0, newCards);
		}

		/// <summary>
		/// Shuffles the deck
		/// </summary>
		public void Shuffle()
		{
			Random rand = new Random();
			for (int i = deck.Count - 1; i > 0; i--)
			{
				int randomIndex = rand.Next(i + 1);
				Card tempCard = deck[i];
				deck[i] = deck[randomIndex];
				deck[randomIndex] = tempCard;
			}
		}

		/// <summary>
		/// Takes the top card from the deck. If the deck is empty, returns null
		/// </summary>
		/// <returns>the top card</returns>
		public Card TakeTopCard()
		{
			if (!Empty)
			{
				Card topCard = deck[deck.Count - 1];
				deck.RemoveAt(deck.Count - 1);
				return topCard;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// Prints the contents of the deck
		/// </summary>
		public void Print()
		{
			foreach (Card card in deck)
			{
				Console.WriteLine(card.Rank + " of " + card.Suit);
			}
		}

	*/
		#endregion
	}
}
