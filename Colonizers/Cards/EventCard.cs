using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	class EventCard : Card
	{
		#region Fields 

		int diceValue = 0;

		#endregion

		#region Properties

		int DiceValue
		{
			get { return diceValue; }
		}

		#endregion

		#region Constructors

		public EventCard(int x, int y) : base(x, y)
		{
			
		}

		#endregion

		#region Methods



		#endregion
	}
}
