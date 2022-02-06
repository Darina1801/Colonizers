﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Cards
{
	public class FleetDevCard : DevelopmentCard
	{
		#region Fields



		#endregion

		#region Properties

		public FleetDevCard(int x, int y) : base(x, y)
		{

		}

		#endregion

		#region Constructors



		#endregion

		#region Methods

		public override void AddCard(Realm realm)
		{
			realm.Fleets.Add(this);
		}

		#endregion

	}
}
