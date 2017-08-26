using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Engine.Models
{
    public class TargetDetails
    {
        public string TargetName { get; }
        public int Height { get; }
        public int Width { get; }

        public TargetDetails(string targetName, int height, int width)
        {
            TargetName = targetName;
            Height = height;
            Width = width;
        }
    }
}
