using System;

namespace BattleShip.Engine.Exceptions
{
    public class WarGamesException : Exception
    {
        public WarGamesException(string message) : base(message)
        {
        }
    }
}