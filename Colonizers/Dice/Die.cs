using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Dice
{
	public class Die
	{
		#region Fields

		int topSide;
		const int NumSides = 6;

		#endregion

		#region Properties

		public int TopSide
		{
			get { return topSide; }
		}


		#endregion

		#region Constructors

		public Die()
		{
			topSide = 6;
		}

		#endregion

		#region Methods

		public void Roll()
		{
			topSide = RandomNumberGenerator.Next(NumSides) + 1;
		}

		#endregion
	}
}
