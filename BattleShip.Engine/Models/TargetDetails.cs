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
        public int Length { get; }
        public int Column { get; set; }
        public int Row { get; set; }

        public TargetDetails(string targetName, int length)
        {
            TargetName = targetName;
            Length = length;
        }
    }
}
