using Colonizers.Cards;
using System.Collections.Generic;

namespace Colonizers
{
	public class Realm
	{
		#region Fields 

		List<FieldDevCard> resorces;
		List<DevelopmentCard> settelmentsAndRoads;
		List<BuildingDevCard> buildings;

		#endregion

		#region Properties

		List<FieldDevCard> Resources
		{
			get { return resorces; }
			set { Resources = value; }
		}

		List<DevelopmentCard> SettelmentsAndRoads
		{
			get { return settelmentsAndRoads; }
			set { SettelmentsAndRoads = value; }
		}
		List<BuildingDevCard> Buildings
		{
			get { return buildings; }
			set { Buildings = value; }
		}

		#endregion

		#region Constructors



		#endregion

		#region Methods

		public void InitializeResourses()
		{
			resorces = new List<FieldDevCard>();
		}

		public void InitializeSettlementsAndRoads()
		{
			settelmentsAndRoads = new List<DevelopmentCard>();
		}
		public void InitializeBuildings()
		{
			buildings = new List<BuildingDevCard>();
		}

		#endregion
	}
}
