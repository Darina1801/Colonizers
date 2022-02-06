using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class CityDevCard : TableDevCard
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

		#region Methods

		public override void AddCard(Realm realm)
		{
			base.AddCard(realm);
		}

		#endregion
	}
}
