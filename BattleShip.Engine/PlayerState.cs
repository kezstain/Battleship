using System;
using System.Collections.Generic;
using System.Linq;
using BattleShip.Engine.Enumerations;
using BattleShip.Engine.Exceptions;
using BattleShip.Engine.Models;

namespace BattleShip.Engine
{
    public class PlayerState
    {
        /// <summary>
        /// The game board tiles
        /// Columns,Rows
        /// </summary>
        public List<TileState> GameBoardTiles { get; private set; }

        /// <summary>
        /// Gets the name of the player.
        /// </summary>
        /// <value>
        /// The name of the player.
        /// </value>
        public string PlayerName { get; }

        public PlayerState(string playerName, int numberOfColumns, int numberOfRows)
        {
            PlayerName = playerName;
            Setup(numberOfColumns, numberOfRows);
        }

        private void Setup(int numberOfColumns, int numberOfRows)
        {
            SetupGameBoardTiles(numberOfColumns, numberOfRows);

            //GameBoardTiles.First(gbt=> gbt.Column == 2 && gbt.Row == 2).HitState = TileHitState.Hit;
        }

        /// <summary>
        /// Sets up the game board tiles.
        /// </summary>
        private void SetupGameBoardTiles(int numberOfColumns, int numberOfRows)
        {
            GameBoardTiles = new List<TileState>();

            for (var colIndex = 0; colIndex < numberOfColumns; colIndex++)
            {
                for (var rowIndex = 0; rowIndex < numberOfRows; rowIndex++)
                {
                    GameBoardTiles.Add(new TileState
                    {
                        Column = colIndex,
                        Row = rowIndex
                    });
                }
            }
        }
    }
}
