using System;
using System.Collections.Generic;
using System.Linq;
using BattleShip.Engine.Exceptions;
using BattleShip.Engine.Models;

namespace BattleShip.Engine
{
    public class Game
    {
        /// <summary>
        /// The game board tiles
        /// Columns,Rows
        /// </summary>
        public List<PlayerState> PlayerStates { get; private set; }
        public int NumberOfColumns { get; private set; }
        public int NumberOfRows { get; private set; }

        public Game(int numberOfColumns, int numberOfRows, params string[] playerNames)
        {
            if (playerNames.Length == 0)
                throw new WarGamesException("Does this look like WarGames to you?");

            NumberOfColumns = numberOfColumns;
            NumberOfRows = numberOfRows;
            Setup(playerNames);
        }

        private void Setup(params string[] playerNames)
        {
            SetupGameBoardTiles(playerNames);
        }

        /// <summary>
        /// Sets up the game board tiles.
        /// </summary>
        private void SetupGameBoardTiles(params string[] playerNames)
        {
            PlayerStates = playerNames.Select(playerName => new PlayerState(playerName, NumberOfColumns, NumberOfRows)).ToList();
        }
    }
}
