using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class VillageDevCard : TableDevCard
	{
		#region Fields

		const int VictoryPoints = 1;

		#endregion

		#region Constructors

		public VillageDevCard(int x, int y) : base(x, y, VictoryPoints)
		{
			CostOre = 3;
			CostGrain = 2;
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
