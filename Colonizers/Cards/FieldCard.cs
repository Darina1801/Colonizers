using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	class FieldCard : Card
	{
		#region Fields 

		int diceValue = 0;

		int valueBrick = 0;
		int valueGold = 0;
		int valueGrain = 0;
		int valueOre = 0;
		int valueWood = 0;
		int valueWool = 0;

		#endregion

		#region Properties

		int DiceValue
		{
			get { return diceValue; }
			set { diceValue = value; }
		}

		int ValueBrick
		{
			get { return valueBrick; }
			set { valueBrick = value; }
		}

		int ValueGold
		{
			get { return valueGold; }
			set { valueGold = value; }
		}

		int ValueGrain
		{
			get { return valueGrain; }
			set { valueGrain = value; }
		}

		int ValueOre
		{
			get { return valueOre; }
			set { valueOre = value; }
		}

		int ValueWood
		{
			get { return valueWood; }
			set { valueWood = value; }
		}

		int ValueWool
		{
			get { return valueWool; }
			set { valueWool = value; }
		}

		#endregion

		#region Constructors



		#endregion

		#region Methods



		#endregion
	}
}
