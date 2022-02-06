using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class CityDevCard : DevelopmentCard
	{
		#region Fields

		const int VictoryPoints = 2;

		#endregion

		#region Constructors

		public CityDevCard(int x, int y) : base(x, y, VictoryPoints)
		{
			CostWood = 1;
			CostWool = 1;
			CostBrick = 1;
			CostGrain = 1;
		}

		#endregion
	}
}
