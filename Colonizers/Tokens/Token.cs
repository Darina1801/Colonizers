using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Tokens
{
	class Token
	{
		#region Fields 

		int victoryPoints = 1;
		int knightPoints;
		int tradePoints;

		#endregion

		#region Properties

		int VictoryPoints
		{
			set { victoryPoints = value; }
		}

		int KnightPoints
		{
			get { return knightPoints; }
		}

		int TradePoints
		{
			get { return tradePoints; }
		}

		#endregion

		#region Constructors



		#endregion

		#region Methods

		public void AddVictoryPoints()
		{
			// Add victory points at the end of Player turn
			//if ()
			{
				// Player.victoryPoints += this.victoryPoints;
			}
		}

		public bool TradeToken()
		{
			// Give Trade token to Player
			if (tradePoints > 0)
			{
				return true;
			}
			else return false;
		}

		public bool KnightToken()
		{
			// Give Knight token to Player
			if (knightPoints > 0)
			{
				return true;
			}
			return false; 
		}

		#endregion
	}
}
