using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BattleShip.Engine.Enumerations;
using BattleShip.Engine.Models;

namespace BattleShip.Controls
{
    public partial class TileDisplay : UserControl
    {
        public TileState TileState;
        private string _playerName;

        public TileDisplay(TileState tileState, string playerName)
        {
            TileState = tileState;
            _playerName = playerName;

            InitializeComponent();

            Height = 60;
            Width = 60;
        }

        public void Draw()
        {
            labelCoordinates.Text = $@"({TileState.Column},{TileState.Row})";
            lblPlayerName.Text = _playerName;
            lblPercentage.Text = TileState.PossibleHits + @"," + TileState.PossibleHitPercentage.ToString("P");
            switch (TileState.HitState)
            {
                case TileHitState.Hit:
                    BackColor = Color.LawnGreen;
                    break;
                case TileHitState.Miss:
                    BackColor = Color.LightGray;
                    break;
                case TileHitState.Unknown:
                    BackColor = Color.LightSeaGreen;
                    break;
            }
        }

        private void labelCoordinates_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
