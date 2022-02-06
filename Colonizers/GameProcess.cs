using Colonizers.Dice;
using Colonizers.Enumerations;
using System;

namespace Colonizers
{
	public static class GameProcess
	{
		#region Fields

		static Die resourseDie;
		static Die eventDie;

		#endregion

		#region Methods

		public static void StartGame()
		{
			Player player1 = new Player(enumPlayerType.RedAndBlack);
			Player player2 = new Player(enumPlayerType.RedAndWhite);

			resourseDie = new Die();
			eventDie = new Die();

			//Ask players to choose places for FieldCards = resources

			Turn(player1, player2);
		}

		public static void Turn(Player player1, Player player2)
		{
			Player player = player2;
			do
			{
				// First switch player who's turn ended
				if (player == player1) player = player2;
				else player = player1;

				resourseDie.Roll();
				eventDie.Roll();
				
				
				
				
			}
			while (CheckPoints(player) == null);
			Victory(player.Name);
		}

		static Player CheckPoints(Player player)
		{
			if (player.VictoryPoints == 12)
			{
				return player;
			}
			else return null;
		}

		static void Victory(string name)
		{
			Console.WriteLine($"Player {name} won!");
		}

		#endregion
	}
}
