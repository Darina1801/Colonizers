using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class VillageDevCard : DevelopmentCard
	{
		#region Fields

		const int VictoryPoints = 1;

		#endregion

		#region Constructors

		public VillageDevCard(int x, int y, int victoryPoints) : base(x, y, VictoryPoints)
		{
			CostOre = 3;
			CostGrain = 2;
		}

		#endregion
	}
}
