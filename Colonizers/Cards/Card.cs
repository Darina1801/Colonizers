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

		bool FaceUp
		{
			get { return faceUp; }
			set { FaceUp = value; }
		}

		string Name
		{
			get { return name; }
			set { Name = value; }
		}

		string Type
		{
			get { return type; }
			set { Type = value; }
		}

		string Description
		{
			get { return description; }
			set { Description = value; }
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
