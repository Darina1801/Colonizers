using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public abstract class TableDevCard : DevelopmentCard
	{
		public TableDevCard(int x, int y, int victoryPoints) : base(x, y, victoryPoints) {}

		public TableDevCard(int x, int y) : base(x, y) {}

		#region Methods

		public override void AddCard(Realm realm)
		{
			realm.SettelmentsAndRoads.Add(this);
		}

		#endregion
	}
}
