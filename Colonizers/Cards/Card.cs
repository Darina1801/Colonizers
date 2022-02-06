using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers
{
	public abstract class Card
	{
		#region Fields 

		bool faceUp;
		string name;
		string type;
		string description;

		int positionX;
		int positionY;

		#endregion

		#region Properties

		public bool FaceUp
		{
			get { return faceUp; }
			set { faceUp = value; }
		}

		string Name
		{
			get { return name; }
			set { name = value; }
		}

		string Type
		{
			get { return type; }
			set { type = value; }
		}

		string Description
		{
			get { return description; }
			set { description = value; }
		}

		public int PositionX
		{
			get { return positionX; }
			protected set { positionX = value; }
		}

		public int PositionY
		{
			get { return positionY; }
			protected set { positionY = value; }
		}

		#endregion

		#region Constructors

		protected Card(int x, int y)
		{
			PositionX = x;
			PositionY = y;
		}

		#endregion

		#region Methods

		public bool FlipOver()
		{
			return faceUp = !faceUp;
		}

		#endregion
	}
}
