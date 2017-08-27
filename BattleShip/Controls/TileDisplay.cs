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
        private TileState _tileState;
        private string _playerName;

        public TileDisplay(TileState tileState, string playerName)
        {
            _tileState = tileState;
            _playerName = playerName;

            InitializeComponent();

            Height = 60;
            Width = 60;
        }

        public void Draw()
        {
            labelCoordinates.Text = $@"({_tileState.Column},{_tileState.Row})";
            lblPlayerName.Text = _playerName;
            lblPercentage.Text = _tileState.PossibleHits + @"," + _tileState.PossibleHitPercentage.ToString("P");
            switch (_tileState.HitState)
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
    }
}
