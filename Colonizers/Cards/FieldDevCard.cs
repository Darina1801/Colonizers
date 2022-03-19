using Colonizers.Enumerations;

namespace Colonizers
{
	public class FieldDevCard : DevelopmentCard
	{
		#region Fields 

		int diceValue;
		enumFieldCards resourseType;
		int quantityOfResourse = 0;
		int resourseExchangeRate = 3;

		#endregion

		#region Properties

		public int DiceValue
		{
			get { return diceValue; }
			set { diceValue = value; }
		}

		public int QuantityOfResourse
		{
			get { return quantityOfResourse; }
			set { quantityOfResourse = value; }
		}

		public enumFieldCards ResourseType
		{
			get { return resourseType; }
			set { resourseType = value; }
		}

		public int ResourseExchangeRate
		{
			get { return resourseExchangeRate; }
			set { resourseExchangeRate = value; }
		}

		#endregion

		#region Constructors

		public FieldDevCard(int x, int y, int diceValue, enumFieldCards resourseType) : base(x, y)
		{
			DiceValue = diceValue;
			ResourseType = resourseType;
		}

		#endregion

		#region Methods

		public override void AddCard(Realm realm)
		{
			realm.Resources.Add(this);
		}

		public void IncreaseResourseAmount()
		{
			if (QuantityOfResourse < 3)
			{
				QuantityOfResourse++;
			}
		}

		#endregion
	}
}
