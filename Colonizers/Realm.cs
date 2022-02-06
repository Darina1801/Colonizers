using Colonizers.Cards;
using System.Collections.Generic;

namespace Colonizers
{
	public class Realm
	{
		#region Fields 

		List<FieldDevCard> resources;
		List<TableDevCard> settelmentsAndRoads;
		List<BuildingDevCard> buildings;
		List<KnightDevCard> knights;
		List<FleetDevCard> fleets;

		#endregion

		#region Properties

		public List<FieldDevCard> Resources
		{
			get { return resources; }
			set { resources = value; }
		}

		public List<TableDevCard> SettelmentsAndRoads
		{
			get { return settelmentsAndRoads; }
			set { settelmentsAndRoads = value; }
		}
		public List<BuildingDevCard> Buildings
		{
			get { return buildings; }
			set { buildings = value; }
		}

		public List<KnightDevCard> Knights
		{
			get { return knights; }
			set { knights = value; }
		}

		public List<FleetDevCard> Fleets
		{
			get { return fleets; }
			set { fleets = value; }
		}

		#endregion

		#region Constructors

		public Realm()
		{
			InitializeResources();
			InitializeSettlementsAndRoads();
			InitializeBuildings();
			InitializeKnights();
			InitializeFleets();
		}

		#endregion

		#region Methods

		public void InitializeResources()
		{
			Resources = new List<FieldDevCard>();
		}

		public void InitializeSettlementsAndRoads()
		{
			SettelmentsAndRoads = new List<TableDevCard>();
		}
		public void InitializeBuildings()
		{
			Buildings = new List<BuildingDevCard>();
		}
		public void InitializeKnights()
		{
			Knights = new List<KnightDevCard>();
		}
		public void InitializeFleets()
		{
			Fleets = new List<FleetDevCard>();
		}

		#endregion
	}
}
