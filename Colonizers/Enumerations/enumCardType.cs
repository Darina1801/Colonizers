using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colonizers.Enumerations
{
	enum enumCardType
	{
		// action cards
		AttackActionCard,
		DefenseActionCard,
		ImprovementActionCard,
		TradeActionCard,

		// development cards
		BuildingDevelopmentCard, 
		FleetDevelopmentCard,
		KnightDevelopmentCard,

		// other card types
		EventCard,
		ExpantionCard,
		FieldCard,
	}
}
