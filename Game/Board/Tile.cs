// Each tile will have a position as well as if its occupied
namespace CsAndPChess.Game.Board
{
    public struct Tile
    {
        public readonly string Name;
        public readonly int Rank; // X
        public readonly int File; // Y
        public bool HasMoved;
    }
}