using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	public abstract class DevelopmentCard : Card
	{
		#region Fields 

		int victoryPoints = 0;

		int costBrick = 0;
		int costGrain = 0;
		int costOre = 0;
		int costWood = 0;
		int costWool = 0;

		#endregion

		#region Properties

		int VictoryPoints
		{
			get { return victoryPoints; }
			set { victoryPoints = value; }
		}

		public int CostBrick
		{
			get { return costBrick; }
			protected set { costBrick = value; }
		}

		public int CostGrain
		{
			get { return costGrain; }
			protected set { costGrain = value; }
		}

		public int CostOre
		{
			get { return costOre; }
			protected set { costOre = value; }
		}

		public int CostWood
		{
			get { return costWood; }
			protected set { costWood = value; }
		}

		public int CostWool
		{
			get { return costWool; }
			protected set { costWool = value; }
		}

		#endregion

		#region Constructors

		protected DevelopmentCard(int x, int y) : base(x, y) {}

		protected DevelopmentCard(int x, int y, int victoryPoints) : base(x, y)
		{
			VictoryPoints = victoryPoints;
		}

		#endregion

		#region Methods

		public abstract void AddCard(Realm realm); 

		#endregion
	}
}
