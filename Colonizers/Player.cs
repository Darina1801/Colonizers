using Colonizers.Cards;
using Colonizers.Enumerations;
using System.Collections.Generic;

namespace Colonizers
{
	public class Player
	{
		#region Fields 

		enumPlayerType playerType;
		string name;
		Realm realm;

		int victoryPoints = 2; //Because at the begining of the game each player has two villages
		int tournamentPoints = 0;
		int knightPoints = 0;

		int valueBrick = 0;
		int valueGold = 0;
		int valueGrain = 0;
		int valueOre = 0;
		int valueWood = 0;
		int valueWool = 0;

		//Unite development cards and персонажей????
		List<Card> hand;

		#endregion

		#region Properties

		enumPlayerType PlayerType
		{
			get { return playerType; }
			set { playerType = value; }
		}

		public string Name 
		{
			get { return name; }
			internal set { name = value; }
		}

		Realm Realm
		{
			get { return realm; }
			set { realm = value; }
		}

		public int VictoryPoints
		{
			get { return victoryPoints; }
			set { victoryPoints = value; }
		}

		int TournamentPoints
		{
			get { return tournamentPoints; }
			set { tournamentPoints = value; }
		}

		int KnightPoints
		{
			get { return knightPoints; }
			set { knightPoints = value; }
		}

		int ValueBrick
		{
			get { return valueBrick; }
			set { valueBrick = value; }
		}

		int ValueGold
		{
			get { return valueGold; }
			set { valueGold = value; }
		}

		int ValueGrain
		{
			get { return valueGrain; }
			set { valueGrain = value; }
		}

		int ValueOre
		{
			get { return valueOre; }
			set { valueOre = value; }
		}

		int ValueWood
		{
			get { return valueWood; }
			set { valueWood = value; }
		}

		int ValueWool
		{
			get { return valueWool; }
			set { valueWool = value; }
		}

		#endregion

		#region Constructors

		public Player(enumPlayerType playerType)
		{
			PlayerType = playerType;
			GenerateRealm();
		}

		#endregion

		#region Methods

		void GenerateRealm()
		{
			this.Realm = new Realm();
			BuildCard(new RoadDevCard(0, 0));
			BuildCard(new VillageDevCard(-1, 0));
			BuildCard(new VillageDevCard(1, 0));
			BuildCard(new FieldDevCard(-2, 1));
			BuildCard(new FieldDevCard(0, 1));
			BuildCard(new FieldDevCard(2, 1));
			BuildCard(new FieldDevCard(-2, -1));
			BuildCard(new FieldDevCard(0, -1));
			BuildCard(new FieldDevCard(2, -1));
		}

		public void BuildCard(DevelopmentCard devCard)
		{
			devCard.AddCard(this.Realm);
			devCard.FaceUp = true;
		}

		public void PlayCard(Card card)
		{

		}

		#endregion
	}
}
