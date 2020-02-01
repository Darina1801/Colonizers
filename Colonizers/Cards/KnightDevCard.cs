using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	class KnightDevCard : DevelopmentCard
	{
		#region Fields

		int tournamentPoints = 0;
		int knightPoints = 0;

		#endregion

		#region Properties

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

		#endregion

		#region Constructors



		#endregion

		#region Methods



		#endregion
	}
}
