// Each tile will have a position
namespace CsAndPChess.Game.Board
{
    public readonly struct Tile
    {
        public int Rank { get; }  // 1 through 8 (representing '1' through '8') x
        public int File { get; } // 1 through 8 (representing 'a' through 'h') y

    }
}