using Colonizers.Enumerations;

namespace Colonizers.CardSets
{
	class CardSet
	{
		#region Fields

		enumCardType cardType;
		string name;
		int countCards;

		#endregion

		#region Properties



		#endregion

		#region Constructors

		public CardSet(enumCardType cardType, string name, int countCards)
		{
			this.cardType = cardType;
			this.name = name;
			this.countCards = countCards;
		}

		#endregion

		#region Methods
		


		#endregion
	}
}
