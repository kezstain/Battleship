using BattleShip.Engine.Enumerations;

namespace BattleShip.Engine.Models
{
    /// <summary>
    /// contains all details of the current tile state
    /// </summary>
    public class TileState
    {
        public TileHitState HitState { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public int PossibleHits { get; set; }
        public decimal PossibleHitPercentage { get; set; }
    }
}
