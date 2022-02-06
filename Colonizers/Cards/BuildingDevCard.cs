using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class BuildingDevCard : DevelopmentCard
	{
		#region Fields

		int victoryPoints = 0;

		#endregion

		#region Properties

		int VictoryPoints
		{
			get { return victoryPoints; }
			set { VictoryPoints = value; }
		}

		#endregion

		#region Constructors

		public BuildingDevCard(int x, int y, int victoryPoints) : base(x, y, victoryPoints)
		{

		}

		#endregion

		#region Methods

		public override void AddCard(Realm realm)
		{
			realm.Buildings.Add(this);
		}

		#endregion
	}
}
