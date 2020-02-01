using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	class Card
	{
		#region Fields 

		bool faceUp;
		string name;
		string cardType;
		string cardDescription;

		#endregion

		#region Properties

		bool FaceUp
		{
			get { return faceUp; }
			set { faceUp = value; }
		}

		string Name
		{
			get { return name; }
			set { name = value; }
		}

		string CardType
		{
			get { return cardType; }
			set { cardType = value; }
		}

		string CardDescription
		{
			get { return cardDescription; }
			set { cardDescription = value; }
		}

		#endregion

		#region Constructors



		#endregion

		#region Methods

		public bool FlipOver()
		{
			if (faceUp == true)
			{
				faceUp = false;
			}
			else
			{
				faceUp = true;
			}

			return faceUp;
		}

		#endregion
	}
}
