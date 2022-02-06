using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class RoadDevCard : TableDevCard
	{
		#region Constructors

		public RoadDevCard(int x, int y) : base(x, y)
		{
			CostWood = 1;
			CostBrick = 2;
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
