using System;

namespace Game.Environment.Tile.Data
{
    [Flags]
    public enum TileProperty
    {
        None = 0,
        Player = 1,
        Collides = 2,
        Movable = 4,
    }
}