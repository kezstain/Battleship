using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BattleShip.Controls;
using BattleShip.Engine;
using BattleShip.Engine.Services;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        private Game Game;

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
                });
            }
            gameBoardTable.ResumeLayout();
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
            Game.PlayerStates.ForEach(PlayerStateHitPercentageHelper.CalculatePossibleHits());
            
        }
    }
}
