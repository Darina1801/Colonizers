namespace Colonizers
{
	public class FieldDevCard : DevelopmentCard
	{
		#region Fields 

		int diceValue = 0;

		//Change to enum with type and make new int value with quantity
		int valueBrick = 0;
		int valueGold = 0;
		int valueGrain = 0;
		int valueOre = 0;
		int valueWood = 0;
		int valueWool = 0;

		#endregion

		#region Properties

		public int DiceValue
		{
			get { return diceValue; }
			set { diceValue = value; }
		}

		public int ValueBrick
		{
			get { return valueBrick; }
			set { valueBrick = value; }
		}

		public int ValueGold
		{
			get { return valueGold; }
			set { valueGold = value; }
		}

		public int ValueGrain
		{
			get { return valueGrain; }
			set { valueGrain = value; }
		}

		public int ValueOre
		{
			get { return valueOre; }
			set { valueOre = value; }
		}

		public int ValueWood
		{
			get { return valueWood; }
			set { valueWood = value; }
		}

		public int ValueWool
		{
			get { return valueWool; }
			set { valueWool = value; }
		}

		#endregion

		#region Constructors

		public FieldDevCard(int x, int y, int diceValue) : base(x, y)
		{
			DiceValue = diceValue;
		}

		#endregion

		#region Methods

		public override void AddCard(Realm realm)
		{
			realm.Resources.Add(this);
		}

		#endregion
	}
}
