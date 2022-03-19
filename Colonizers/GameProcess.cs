using Colonizers.Actions;
using Colonizers.Dice;
using Colonizers.Enumerations;
using System;
using System.Linq;

namespace Colonizers
{
	public static class GameProcess
	{
		#region Fields

		static Die resourseDie;
		static Die eventDie;

		static bool endTurn;

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
			Player currentPlayer = player2;
			do
			{
				// First switch player who's turn ended
				if (currentPlayer == player1) currentPlayer = player2;
				else currentPlayer = player1;

				resourseDie.Roll();
				eventDie.Roll();

				//Increase resources with die roll
				player1.Realm.Resources.Where(x => x.DiceValue == resourseDie.TopSide).ToList().ForEach(x => x.IncreaseResourseAmount());
				player2.Realm.Resources.Where(x => x.DiceValue == resourseDie.TopSide).ToList().ForEach(x => x.IncreaseResourseAmount());

				//TODO Apply eventDieResult
				var eventDieResult = (enumEventDiceSides)eventDie.TopSide;

				//currentPlayerActions
				while (!endTurn)
				{
					AskForAction(currentPlayer);
				}
			}
			while (CheckPoints(currentPlayer) == null);
			Victory(currentPlayer.Name);
		}

		static void AskForAction(Player player)
		{
			PlayerAction action = player.ActionChoice();

			if (action is EndTurnAction)
			{
				endTurn = true;
			}
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
