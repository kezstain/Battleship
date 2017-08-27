using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BattleShip.Controls;
using BattleShip.Engine;
using BattleShip.Engine.Enumerations;
using BattleShip.Engine.Models;
using BattleShip.Engine.Services;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        private Game Game;
        private TileDisplay EditingTileDisplay { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetupGame_Click(object sender, System.EventArgs e)
        {
            gameBoardTable.Controls.Clear();
            Game = new Game(10,10, new []{"Comp","P1"});
            InitializeBoard();
            //DrawBoard();
        }

        /// <summary>
        /// Initializes the board.
        /// </summary>
        private void InitializeBoard()
        {
            gameBoardTable.SuspendLayout();
            gameBoardTable.Controls.Clear();
            gameBoardTable.RowCount = Game.NumberOfRows;
            gameBoardTable.ColumnCount = Game.NumberOfColumns;
            foreach (RowStyle rowStyle in gameBoardTable.RowStyles)
            {
                rowStyle.SizeType = SizeType.AutoSize;
            }
            foreach (ColumnStyle colStyle in gameBoardTable.ColumnStyles)
            {
                colStyle.SizeType = SizeType.AutoSize;
            }

            for (int playerIndex = 0; playerIndex < Game.PlayerStates.Count; playerIndex++)
            {
                var playerState = Game.PlayerStates[playerIndex];
                playerState.GameBoardTiles.ForEach(gameBoardTile =>
                {
                    var tileDisplay = new TileDisplay(gameBoardTile, playerState.PlayerName);
                    gameBoardTable.Controls.Add(tileDisplay, gameBoardTile.Column, gameBoardTile.Row+Game.NumberOfRows*playerIndex);
                    tileDisplay.Draw();
                    tileDisplay.Click += TileDisplay_Click;
                });
            }
            gameBoardTable.ResumeLayout();
        }

        private void TileDisplay_Click(object sender, System.EventArgs e)
        {
            EditingTileDisplay = (TileDisplay) sender;
            switch (EditingTileDisplay.TileState.HitState)
            {
                case TileHitState.Unknown:
                    rdoUnknown.Checked = true;
                    break;
                case TileHitState.Hit:
                    rdoHit.Checked = true;
                    break;
                case TileHitState.Miss:
                    rdoMiss.Checked = true;
                    break;
            }
            lblHitPercentage.Text = @"Possible Hits: " + EditingTileDisplay.TileState.PossibleHits + @" (" + EditingTileDisplay.TileState.PossibleHitPercentage.ToString("P") + @")";
        }

        private void DrawBoard()
        {
            gameBoardTable.SuspendLayout();
            foreach (var tileDisplay in gameBoardTable.Controls.OfType<TileDisplay>())
            {
                //unsafe code for testing only
                tileDisplay.Draw();
            }
            gameBoardTable.ResumeLayout();
        }

        private void btnCalculateHitPercent_Click(object sender, System.EventArgs e)
        {
            var ships = new List<TargetDetails>
            {
                new TargetDetails("Small Ship",5),
                new TargetDetails("Small Ship",4),
                new TargetDetails("Small Ship",3),
                new TargetDetails("Small Ship",3),
                new TargetDetails("Small Ship",2)
            };
            Game.PlayerStates.ForEach(PlayerStateHitPercentageHelper.CalculatePossibleHits(ships));
            DrawBoard();
        }

        private void rdoUnknown_CheckedChanged(object sender, System.EventArgs e)
        {
            EditingTileDisplay.TileState.HitState=TileHitState.Unknown;
            DrawBoard();
        }

        private void rdoHit_CheckedChanged(object sender, System.EventArgs e)
        {
            EditingTileDisplay.TileState.HitState = TileHitState.Hit;
            DrawBoard();
        }

        private void rdoMiss_CheckedChanged(object sender, System.EventArgs e)
        {
            EditingTileDisplay.TileState.HitState = TileHitState.Miss;
            DrawBoard();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            DrawBoard();
        }
    }
}
