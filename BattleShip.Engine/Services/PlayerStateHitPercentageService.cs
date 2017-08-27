using System;
using System.Collections.Generic;
using System.Linq;
using BattleShip.Engine.Models;

namespace BattleShip.Engine.Services
{
    public class PlayerStateHitPercentageHelper
    {
        public static Action<PlayerState> CalculatePossibleHits(List<TargetDetails> shipDimensions)
        {
            return playerState =>
            {
                //reset possible hits
                ResetPossibleHits(playerState);

                //this could be optimized later through an array
                //not important at the moment
                foreach (var shipDimension in shipDimensions)
                {
                    foreach (var gameBoardTile in playerState.GameBoardTiles)
                    {
                        //check horizontal
                        ScanHorizontally(gameBoardTile, shipDimension, playerState);

                        //check vertical
                        ScanVertically(gameBoardTile, shipDimension, playerState);
                    }
                }

                //and also calculate the percentage
                var totalPossibleHits = (decimal)playerState.GameBoardTiles.Sum(ts => ts.PossibleHits);
                if(totalPossibleHits>0)
                    playerState.GameBoardTiles.ForEach(ts => ts.PossibleHitPercentage = ts.PossibleHits / totalPossibleHits);
                else
                    playerState.GameBoardTiles.ForEach(ts => ts.PossibleHitPercentage = 0);
            };
        }

        private static void ScanHorizontally(TileState gameBoardTile, TargetDetails shipDimension, PlayerState playerState)
        {
            var targets = new List<TileState>();
            for (var columnIndex = gameBoardTile.Column; columnIndex < gameBoardTile.Column + shipDimension.Length; columnIndex++)
            {
                //performs first or default matches to support future none square grids
                var index = columnIndex;
                var tileState = playerState.GameBoardTiles.FirstOrDefault(x => x.Column == index && x.Row == gameBoardTile.Row);
                if (tileState != null)
                {
                    targets.Add(tileState);
                }
            }
            if (targets.Count == shipDimension.Length)
            {
                targets.ForEach(target => { target.PossibleHits++; });
            }
        }

        private static void ScanVertically(TileState gameBoardTile, TargetDetails shipDimension, PlayerState playerState)
        {
            var targets = new List<TileState>();
            for (var rowIndex = gameBoardTile.Row; rowIndex < gameBoardTile.Row + shipDimension.Length; rowIndex++)
            {
                //performs first or default matches to support future none square grids
                var index = rowIndex;
                var tileState = playerState.GameBoardTiles.FirstOrDefault(x => x.Row == index && x.Column == gameBoardTile.Column);
                if (tileState != null)
                {
                    targets.Add(tileState);
                }
            }
            if (targets.Count == shipDimension.Length)
            {
                targets.ForEach(target => { target.PossibleHits++; });
            }
        }

        private static void ResetPossibleHits(PlayerState playerState)
        {
            playerState.GameBoardTiles.ForEach(x => x.PossibleHits = 0);
        }
    }
}
